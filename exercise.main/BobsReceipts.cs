using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class BobsReceipts : IReceipt
    {
        private string shopName =    "       ~~~ Bob's Bagels ~~~";
        private string decorator =   "  ------------------------------";
        private string endMessage1 = "             Thank you\n";
        private string endMessage2 = "          for your order!";

        DateTime dt = DateTime.Now;

        public string WriteReceipt(string productList, string total)// Dictionary<Product, double> productPrices)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(String.Format("{3,8}" + "\n\n       {0, 12}\n\n" + "{4,8}" +"\n{1,20}\n" + "{4,8}" + "\n   Total:\t\t{2,8}\n\n"+ endMessage1 + endMessage2, dt.ToString(), productList, total, shopName, decorator));

            return sb.ToString();
        }
    }
}
