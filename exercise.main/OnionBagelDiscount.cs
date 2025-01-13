using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    internal class OnionBagelDiscount : IDiscount
    {
        public double CheckDiscount(List<Product> products)
        {
            double discountedPrice = 0;

            bool getDiscount = false;

            List<Product> OnionBagelList = products.Where(p => p.SKU.Equals("BGLO")).ToList();


            if(OnionBagelList.Count > 5)
            {
                getDiscount = true;
                discountedPrice += 2.49;
            }

            for(int i = (getDiscount) ? 6: 0; i < OnionBagelList.Count; i++)
            {
                discountedPrice += OnionBagelList[i].Price;
            }

            return discountedPrice;
        }
    }
}
