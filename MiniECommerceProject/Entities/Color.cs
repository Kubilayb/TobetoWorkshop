using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Color
    {
        public Color(int colorId, string colorName)
        {
            ColorId = colorId;
            ColorName = colorName;
        }

        public int ColorId { get; set; }
        public string ColorName { get; set; }

        public virtual ICollection<ProductColors> ProductColors { get; set; }

    }
}
