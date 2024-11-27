using System;
using System.Collections.Generic;

namespace Lastname_Project
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        private List<Product> Products { get; set; }

        public Order(int orderId, DateTime orderDate)
        {
            OrderId = orderId;
            OrderDate = orderDate;
            Products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
            Console.WriteLine($"Product {product.Name} added to the order.");
        }

        public decimal CalculateTotal()
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
            return $"Order ID: {OrderId}, Date: {OrderDate}, Total: {CalculateTotal():C}";
        }
    }
}
