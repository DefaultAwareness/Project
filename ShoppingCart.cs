using System;
using System.Collections.Generic;

namespace Lastname_Project
{
    public class ShoppingCart
    {
        private List<Product> Products { get; set; }

        public ShoppingCart()
        {
            Products = new List<Product>();
        }

        public void AddToCart(Product product)
        {
            Products.Add(product);
            Console.WriteLine($"Product {product.Name} added to the cart.");
        }

        public void RemoveFromCart(Product product)
        {
            Products.Remove(product);
            Console.WriteLine($"Product {product.Name} removed from the cart.");
        }

        public decimal CalculateCartTotal()
        {
            decimal total = 0;
            foreach (var product in Products)
            {
                total += product.Price;
            }
            return total;
        }

        public override string ToString()
        {
            return $"Shopping Cart Total: {CalculateCartTotal():C}";
        }
    }
}
