using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_Examples._2_Inheritance.Entities
{
    public class BaseCustomer
    {
        public int Id { get; set; }

        public string CustomerNumber { get; set; }

        public string Address { get; set; }
    }

    // inheritance : Base customer içine bireysel ve kurumsal müşterilerde ortak olarak kullanılan bilgileri girdik.
    // İkinizde müşterisiniz dedik
}
