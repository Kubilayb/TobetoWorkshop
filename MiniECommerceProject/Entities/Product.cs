namespace Entities
{
    public class Product
    {
        public Product()
        {
        }

        public Product(int productId, string productName, string size, int stock, double price)
        {
            ProductId = productId;
            ProductName = productName;
            Size = size;
            Stock = stock;
            Price = price;
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Size { get; set; }
        public int Stock { get; set; }
        public double Price { get; set; }

        public ICollection<ProductColors> ProductColors { get; set; }

    }
}
