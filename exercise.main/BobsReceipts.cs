using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class BobsReceipts : IReceipt
    {
        private string shopName = "~~~ Bob's Bagels ~~~";
        private string decorator = "----------------------------";
        private string endMessage1 = "Thank you\n";
        private string endMessage2 = "for your order!";

        DateTime dt = DateTime.Now;

        public string WriteReceipt(string productList, string total)// Dictionary<Product, double> productPrices)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(String.Format(shopName + "\n{0, 12}\n\n" + decorator +"\n{1,20}\n" + decorator +"\nTotal:\t\t{2,8}\n"+ endMessage1 + endMessage2, dt.ToString(), productList, total));

            return sb.ToString();
        }
    }
}
