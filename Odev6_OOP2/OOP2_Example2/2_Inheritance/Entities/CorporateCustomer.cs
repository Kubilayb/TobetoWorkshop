using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_Examples._2_Inheritance.Entities
{
    public class CorporateCustomer : BaseCustomer
    {
        public string Name { get; set; }
        public string TaxNumber { get; set; }
    }
}
