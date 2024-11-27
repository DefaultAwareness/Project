using System;

namespace Lastname_Project
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Example usage
            User user = new User(1, "JohnDoe", "john@example.com");
            user.Login();

            Product product1 = new Product(101, "Laptop", 999.99m);
            Product product2 = new Product(102, "Mouse", 19.99m);

            ShoppingCart cart = new ShoppingCart();
            cart.AddToCart(product1);
            cart.AddToCart(product2);

            Console.WriteLine(cart);

            Order order = new Order(1, DateTime.Now);
            order.AddProduct(product1);
            order.AddProduct(product2);

            Console.WriteLine(order);

            Payment payment = new Payment(1, order.CalculateTotal(), "Credit Card");
            payment.ProcessPayment();

            user.Logout();
        }
    }
}
