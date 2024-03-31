using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Interfaces
{
    // POLYMORPHISM = Çok biçimlilik bir nesneyi farklı
    // amaçlarla implemente edip o implemasyonların belli bir kısmına veya tamamına ulaşmaktır


    interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();
    }

    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql Added!");
        }

        public void Delete()
        {
            Console.WriteLine("Sql Deleted!");

        }

        public void Update()
        {
            Console.WriteLine("Sql Updated!");

        }
    }
    class OracleServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle Server Added!");

        }

        public void Delete()
        {
            Console.WriteLine("Oracle Server Deleted!");

        }

        public void Update()
        {
            Console.WriteLine("Oracle Server Updated!");

        }
    }
    class MySqlCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Mysql  Added!");

        }

        public void Delete()
        {
            Console.WriteLine("Mysql Deleted!");

        }

        public void Update()
        {
            Console.WriteLine("Mysql Updated!");

        }
    }

    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }
    }
}
