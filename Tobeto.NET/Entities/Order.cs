﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Order
    {
        public Order() { }

        public Order(int id)
        {
            Id = id;
        }

        public int Id { get; set; }

       // public virtual ICollection<OrderDetail> OrderDetails { get; set; }

    }
}
