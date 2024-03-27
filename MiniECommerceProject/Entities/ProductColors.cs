using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ProductColors
    {
        public int ProductColorsId { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public int ColorId { get; set; }
        public virtual Color Color { get; set; }

    }
}
