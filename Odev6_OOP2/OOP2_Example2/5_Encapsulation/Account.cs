using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_Examples._5_Encapsulation
{
    public class Account
    {
        string _userName;

        public string userName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        public string password { get; set; }
    }
}
