using System;
using System.Collections.Generic;

namespace Lastname_Project
{
    public class Inventory
    {
        private List<Product> Products { get; set; }

        public Inventory()
        {
            Products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
            Console.WriteLine($"Product {product.Name} added to inventory.");
        }

        public void ListProducts()
        {
            Console.WriteLine("Inventory Products:");
            foreach (var product in Products)
            {
                Console.WriteLine(product);
            }
        }
    }
}
