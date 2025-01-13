using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exercise.main
{
    public class Basket
    {
        private List<Product> products;
        public int Capacity {  get; set; }
        private int currentAmountOfProducts;
        private double totalCost;
        private Dictionary<Product, double> ProductPrice;
        private Dictionary<Product, int> ProductAmount;

        public Basket()
        {
            ProductPrice = new Dictionary<Product, double>();
            ProductAmount = new Dictionary<Product, int>();
            products = new List<Product>();
            Capacity = 18;
            currentAmountOfProducts = 0;
            totalCost = 0;
        }
        public bool AddProduct(Product p)
        {
            if(currentAmountOfProducts < Capacity)
            {
                products.Add(p);
                totalCost += p.Price;
                currentAmountOfProducts++;

                if (ProductAmount.ContainsKey(p))
                {
                    ProductAmount[p]++;
                }
                else
                {
                    ProductAmount.Add(p, 1);
                }

                UpdateTotalPriceTest();
                return true;
            }

            return false;
        }

        public bool RemoveProduct(string SKU)
        {
            foreach (Product p in products)
            {
                if (p.SKU == SKU)
                {
                    products.Remove(p);
                    totalCost -= p.Price;
                    currentAmountOfProducts--;

                    if (ProductAmount.ContainsKey(p))
                    {
                        ProductAmount[p]--;
                    }

                    if(ProductAmount[p] == 0)
                        ProductAmount.Remove(p);

                    return true;
                }
            }
            return false;
        }

        public double TotalCost()
        {
            return totalCost;
        }

        public string AllProducts()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Product p in products)
            {
                sb.Append(p.ToString() + "\n");
            }

            return sb.ToString();
        }

        public string PrintBasket()
        {

            StringBuilder sb = new StringBuilder();

            foreach(KeyValuePair<Product, double> kp in ProductPrice)
            {
                //sb.Append(kp.Key.Variant + "\t" + ProductAmount[kp.Key]+"\t£"+ kp.Value + "\n");
                sb.Append(String.Format("{0,12}\t{1,4}\t{2,8}\n", kp.Key.Variant, ProductAmount[kp.Key], "£"+ kp.Value));
            }

            return sb.ToString();
        }

        public Dictionary<Product, double> UpdateTotalPrice()
        {
            IDiscount onionBagel = new OnionBagelDiscount();

            Dictionary<Product, double>  productTotalPrices = new Dictionary<Product, double>();

            foreach (Product p in products.Distinct())
            {
                if(p.SKU == "BGLO" && !productTotalPrices.ContainsKey(p))
                {
                    productTotalPrices.Add(p, onionBagel.CheckDiscount(products));
                }
                else if (productTotalPrices.ContainsKey(p))
                {
                    productTotalPrices[p] += p.Price;
                }
                else
                {
                    productTotalPrices.Add(p, p.Price);
                }
            }

            return productTotalPrices;
        }

        public void UpdateTotalPriceTest()
        {
            IDiscount onionBagel = new OnionBagelDiscount();

            ProductPrice = new Dictionary<Product, double>();

            foreach (Product p in products.Distinct())
            {
                if (p.SKU == "BGLO" && !ProductPrice.ContainsKey(p))
                {
                    ProductPrice.Add(p, onionBagel.CheckDiscount(products));
                }
                else if (ProductPrice.ContainsKey(p))
                {
                    ProductPrice[p] += p.Price;
                }
                else
                {
                    ProductPrice.Add(p, p.Price);
                }
            }
        }

        public Product GetProduct(string SKU, out bool exists)
        {
            Product temp = null;

            foreach (Product p in products)
            {
                if(p.SKU == SKU)
                {
                    exists = true;
                    temp = p; break;
                }
            }
            exists = false;
            return temp;
        }
    }
}