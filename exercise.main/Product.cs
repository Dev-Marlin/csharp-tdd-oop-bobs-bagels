﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exercise.main
{
    public abstract class Product
    {
        public double Price { get; set; }

        public string Name { get; set; }

        public string SKU { get; set; }

        public string Variant { get; set; }

        public Product(double price, string name, string sku, string variant) 
        { 
            Price = price;
            Name = name;
            SKU = sku;
            Variant = variant;
        }
    }
}