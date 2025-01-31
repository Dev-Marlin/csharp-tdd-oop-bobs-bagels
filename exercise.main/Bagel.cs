﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exercise.main
{
    public class Bagel : Product
    {
        List<Filling> filling;
        public int FillingCapacity { get; set; }
        private int currentAmountOfFilling;
        public Bagel(double price, string name, string sku, string variant) : base(price, name, sku, variant)
        {
            filling = new List<Filling>();
            FillingCapacity = 4;
            currentAmountOfFilling = 0;
        }

        public bool AddFilling(Filling f)
        {
            if(FillingCapacity > currentAmountOfFilling)
            {
                filling.Add(f);
                currentAmountOfFilling++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public string AllTheFilling()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Filling f in filling)
            {
                sb.Append(f.ToString() + "\n");
            }

            return sb.ToString();
        }

        public double CheckFillingPrice()
        {
            double totalPrice = 0;

            foreach (Filling f in filling)
            {
                totalPrice += f.Price;
            }

            return totalPrice;
        }

        public override string ToString()
        {
            return Name + " "+ Variant;
        }

    }
}