using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    internal interface IDiscount
    {
        public double CheckDiscount(List<Product> products);
    }
}
