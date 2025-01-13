using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    internal class CoffeeDiscount : IDiscount
    {
        public double CheckDiscount(List<Product> products)
        {
            double discountedPrice = 0;

            bool getDiscount = false;

            foreach (Product p in products)
            {
                if(p.SKU == "COFB" && !getDiscount)
                {
                    discountedPrice += 1.25;
                }
                else if(p.SKU == "COFB")
                {
                    discountedPrice += 0.99;
                }
            }

            return discountedPrice;
        }
    }
}
