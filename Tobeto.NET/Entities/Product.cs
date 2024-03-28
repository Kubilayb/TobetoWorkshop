using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Product
    {
        public Product()
        {
        }
        public Product(int productId, string name, double unitPrice, int stock, int categoryId)
        {
            ProductId = productId;
            Name = name;
            UnitPrice = unitPrice;
            Stock = stock;
            CategoryId = categoryId;
        }

        public int ProductId { get; set; }
        public string Name { get; set; }
        public double UnitPrice { get; set; }
        public int Stock { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}