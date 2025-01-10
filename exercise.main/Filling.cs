using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace exercise.main
{
    public class Filling : Product
   {
        public Filling(double price, string name, string sku, string variant) : base(price, name, sku, variant)
        {

        }

        public override string ToString()
        {
            return Variant;
        }
    }
}