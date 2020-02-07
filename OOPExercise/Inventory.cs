using System;
using System.Collections.Generic;

namespace OOPExercise
{
    static class Inventory
    {
        private static readonly List<Product> Products;

        static Inventory()
        {
            Products = new List<Product>();
        }

        public static void AddProduct(Product p)
        {
            Products.Add(p);
        }

        public static void DisplayInventory()
        {
            double totalInventoryValue = 0;
            Console.WriteLine("Current inventory: ");
            Console.WriteLine("===========================================\n");
            foreach (Product p in Products)
            {
                p.DisplayInfo();
                Console.WriteLine();
                totalInventoryValue += p.GetTotalValue();
            }

            Console.WriteLine($"Total inventory value: ${totalInventoryValue:F}");
        }
    }
}
