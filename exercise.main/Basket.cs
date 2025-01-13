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

        public Basket()
        {
            products = new List<Product>();
            Capacity = 8;
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
            Dictionary<Product, double> ProductPrice = new Dictionary<Product, double>();
            Dictionary<Product, int> ProductAmount = new Dictionary<Product, int>();

            foreach(Product p in products)
            {
                /*
                 * CODE FOR PRICES AND APPLYING DISCOUNTS
                 * */

                if (ProductAmount.ContainsKey(p))
                {
                    ProductAmount[p]++;
                }
                else
                {
                    ProductAmount.Add(p, 1);
                }
            }

            StringBuilder sb = new StringBuilder();

            foreach(KeyValuePair<Product, double> kp in ProductPrice)
            {
                sb.Append(kp.Key.Variant + "\t" + ProductAmount[kp.Key]+"\t"+ kp.Value + "\n");
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