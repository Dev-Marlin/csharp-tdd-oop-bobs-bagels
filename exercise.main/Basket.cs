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
        public bool AddProduct(Product p)
        {
            throw new System.NotImplementedException();
        }

        public bool RemoveProduct(string SKU)
        {
            throw new System.NotImplementedException();
        }

        public double TotalCost()
        {
            throw new System.NotImplementedException();
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