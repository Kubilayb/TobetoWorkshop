﻿using System;
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

        public Product(int id, string name, double unitPrice, int stock)
        {
            Id = id;
            Name = name;
            UnitPrice = unitPrice;
            stock = stock;

        }

        public int Id { get; set; }
        public string Name { get; set; }
        public double UnitPrice { get; set; }

        public int Stock { get; set; }

    }
}