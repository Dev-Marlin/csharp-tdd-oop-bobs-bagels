using exercise.main;

namespace exercise.test;

public class Tests
{

    [Test]
    public void AddProductTest()
    {
        Basket basket = new Basket();
        Product a = new Bagel(0.1, "Bagel", "BGLO", "Onion");
        basket.AddProduct(a);
        Product b = basket.GetProduct("BGLO", out bool exists);

        Assert.That(a.SKU, Is.EqualTo(b.SKU));
    }

    [Test]
    public void RemoveProductTest()
    {
        Basket basket = new Basket();
        Product a = new Bagel(0.1, "Bagel", "BGLO", "Onion");
        basket.AddProduct(a);
        basket.RemoveProduct("BGLO");
        Product b = basket.GetProduct("BGLO", out bool exists);

        Assert.That(exists, Is.False);
    }

    [Test]
    public void RemoveGhostProductTest()
    {
        Basket basket = new Basket();
        Product b = basket.GetProduct("BGLO", out bool exists);

        Assert.That(exists, Is.False);
    }

    [Test]
    public void TotalBasketCostTest()
    {
        Basket basket = new Basket();
        double totalCost1 = 0;
        Random rand = new Random();
        for(double i = 1.0; i < 6; i++)
        {
            i += rand.NextDouble();
            totalCost1 += i;
            basket.AddProduct(new Bagel(i, "Bagel", "BGLO", "Onion"));
        }

        double totalCost2 = basket.TotalCost();

        Assert.That(totalCost1, Is.EqualTo(totalCost2));
    }

    [Test]
    public void TotalFillingCostTest()
    {
        Bagel b = new Bagel(0.5, "Bagel", "BGLO", "Onion");

        Filling f1 = new Filling(0.12, "Filling", "FILB", "Bacon");
        Filling f2 = new Filling(0.12, "Filling", "FILE", "Egg");
        Filling f3 = new Filling(0.12, "Filling", "FILE", "Cheese");
        Filling f4 = new Filling(0.12, "Filling", "FILE", "Cream Cheese");


        double fillingCost = 0.48;

        b.AddFilling(f1);
        b.AddFilling(f2);
        b.AddFilling(f3);
        b.AddFilling(f4);

        Assert.That(b.CheckFillingPrice(), Is.EqualTo(fillingCost));
    }

    [Test]
    public void AddFillingTest()
    {
        Bagel b = new Bagel(0.5, "Bagel", "BGLO", "Onion");

        Filling f1 = new Filling(0.12, "Filling", "FILB", "Bacon");
        Filling f2 = new Filling(0.12, "Filling", "FILE", "Egg");

        string theWantedFilling = "Bacon\nEgg\n";

        b.AddFilling(f1);
        b.AddFilling(f2);

        string fillingList = b.AllTheFilling();

        Assert.That(fillingList, Is.EqualTo(theWantedFilling));
    }

    [Test]
    public void BasketCapacityTest()
    {
        Basket basket = new Basket();

        bool canAdd = true;

        for (int i = 1; i < 8; i++)
        {
            canAdd = basket.AddProduct(new Bagel(i, "Bagel", "BGLO", "Onion"));
        }


        Assert.That(canAdd, Is.EqualTo(false));
    }

    [Test]
    public void ChangeBasketCapacityTest()
    {
        Basket basket = new Basket();

        int cap = basket.Capacity;

        basket.Capacity = 10;

        Assert.That(basket.Capacity, Is.EqualTo(10));
    }


    [Test]
    public void ProductInInventoryTestPass()
    {
        Inventory I = new Inventory();

        bool isItIn = I.ProductInInventory("FILE", out Product product);

        Assert.That(isItIn, Is.True);
    }

    [Test]
    public void ProductInInventoryTestFail()
    {
        Inventory I = new Inventory();

        bool isItIn = I.ProductInInventory("ADAD", out Product product);

        Assert.That(isItIn, Is.False);
    }

    [Test]
    public void GetDiscountTest()
    {
        Basket basket = new Basket();

        for (int i = 1; i < 6; i++)
        {
            basket.AddProduct(new Bagel(0.49, "Bagel", "BGLO", "Onion"));
        }


        Assert.That(basket.TotalCost, Is.EqualTo(2.49));
    }

    [Test]
    public void NoDiscountTest()
    {
        Basket basket = new Basket();


        for (int i = 1; i < 5; i++)
        {
            basket.AddProduct(new Bagel(0.49, "Bagel", "BGLO", "Onion"));
        }


        Assert.That(basket.TotalCost, Is.EqualTo(0.49*5.0));
    }

}