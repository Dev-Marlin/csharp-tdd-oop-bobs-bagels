using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exercise.main
{
    public class Inventory
    {
        private List<Product> inventory;

        public Inventory()
        {
            inventory = new List<Product>();
            initializeInventory();
        }

        public bool ProductInInventory(string sku, out Product product)
        {
            foreach(Product p in inventory)
            {
                if (sku.Equals(p.SKU))
                {
                    product = p;
                    return true;
                }
            }

            product = null;
            return false;
        }

        public void AddProductToInventory()
        {
            throw new System.NotImplementedException();
        }

        private void initializeInventory()
        {
            //Bagels
            inventory.Add(new Bagel(0.49, "Bagel", "BGLO", "Onion"));
            inventory.Add(new Bagel(0.39, "Bagel", "BGLP", "Plain"));
            inventory.Add(new Bagel(0.49, "Bagel", "BGLE", "Everything"));
            inventory.Add(new Bagel(0.49, "Bagel", "BGLS", "Sesame"));

            //Coffee
            inventory.Add(new Coffee(0.99, "Coffee", "COFB", "Black"));
            inventory.Add(new Coffee(1.19, "Coffee", "COFW", "White"));
            inventory.Add(new Coffee(1.29, "Coffee", "COFC", "Capuccino"));
            inventory.Add(new Coffee(1.29, "Coffee", "COFL", "Latte"));

            //Fillings
            inventory.Add(new Filling(0.12, "Filling", "FILB", "Bacon"));
            inventory.Add(new Filling(0.12, "Filling", "FILE", "Egg"));
            inventory.Add(new Filling(0.12, "Filling", "FILE", "Cheese"));
            inventory.Add(new Filling(0.12, "Filling", "FILE", "Cream Cheese"));
            inventory.Add(new Filling(0.12, "Filling", "FILE", "Smoked Salmon"));
            inventory.Add(new Filling(0.12, "Filling", "FILE", "Ham"));
        }
    }
}