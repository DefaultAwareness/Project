namespace Lastname_Project
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Product(int productId, string name, decimal price)
        {
            ProductId = productId;
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"Product ID: {ProductId}, Name: {Name}, Price: {Price:C}";
        }
    }
}
