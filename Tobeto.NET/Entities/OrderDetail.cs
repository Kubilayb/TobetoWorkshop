using Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class OrderDetail : Entity
    {
        public OrderDetail() { }

        public OrderDetail(int id, double totalPrice, int quantity, int discount)
        {
            Id = id;
            TotalPrice = totalPrice;
            Quantity = quantity;
            Discount = discount;
        }

        public int Id { get; set; }

        public double TotalPrice { get; set; }

        public int Quantity { get; set; }

        public int Discount { get; set; }
        /*
        public virtual Product Product { get; set; }
        public int ProductId { get; set; }

        public virtual Order Order { get; set; }
        public int OrderId { get; set; }  */
    }
}
