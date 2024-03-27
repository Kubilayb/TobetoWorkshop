using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Customer

    {
        public Customer(int id, string firstname, string lastname, string phonenumber)
        {
            Id = id;
            FirstName = firstname;
            LastName = lastname;
            PhoneNumber = phonenumber;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }

    }
}
