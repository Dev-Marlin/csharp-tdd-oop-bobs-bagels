// See https://aka.ms/new-console-template for more information
using exercise.main;
BobsReceipts br = new BobsReceipts();
Basket basket = new Basket();
Product p = new Bagel(0.49, "Bagel", "BGLO", "Onion");
Product p1 = new Coffee(0.99, "Coffee", "COFB", "Black");
Product p2 = new Bagel(0.69, "Bagel", "BGLE", "Everything");
basket.AddProduct(p2);
for (int i = 0; i < 6; i++)
{
    basket.AddProduct(p);
}

basket.AddProduct(p1);
basket.AddProduct(p2);

//Console.WriteLine(basket.PrintBasket());
Console.WriteLine(br.WriteReceipt(basket.PrintBasket(), basket.TotalCost().ToString()));