using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exercise.main
{
    public class Coffee : Product
    {
        public Coffee(double price, string name, string sku, string variant) : base(price, name, sku, variant)
        {

        }

        public override string ToString()
        {
            return Variant;
        }
    }
}