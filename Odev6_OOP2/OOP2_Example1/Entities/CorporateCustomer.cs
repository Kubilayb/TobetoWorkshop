using OOP2_Example1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_Example1.Entities;

public class CorporateCustomer : BaseCustomer
{
    public string Name { get; set; }
    public string TaxNumber { get; set; }
}
