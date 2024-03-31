using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Classes
{


    // Property Müşterinin özellikleri
    class Customer
    {
        // Field tanımlamak
        // public string FirstName;

        // Property tanımlamak get set
        public int Id { get; set; }
        // Encapsulation yapıcaz get set içine özellik eklicez
        private string _firstName; // field tanımlamak gerekiyor
        public string FirstName

        {
            get { return "Mrs." + _firstName; }     // Bu tip eski bir kullanımdır.
            set { _firstName = value; }
        }


                // Güncel işlem auto property oluyor 
        public string LastName { get; set; }

        public string City { get; set; }
    }
}
