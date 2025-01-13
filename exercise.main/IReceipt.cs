using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    internal interface IReceipt
    {
        public string WriteReceipt(string list, string total); //Dictionary<Product, double> productPrices);
    }
}
