namespace OOP_Odev
{
    /*
    class Program
    {
        
        static void Main(string[] args)
        {
             
                    Referans Tipleri Anlamak            
            
            int[] sayilar1 = new[] { 1, 2, 3 };
            int[] sayilar2 = new[] { 10, 20, 30 };

            sayilar1 = sayilar2;
            sayilar2[0] = 1000;

            Console.WriteLine(sayilar1[0]);   
    }
    */

    /*
    class Program
    {
       
        static void Main(string[] args)
        {

            CreditManager creditManager = new CreditManager(); //referans oluşturduk = parantez içi bizim metot yerimiz aslında
            creditManager.Calculate();
            creditManager.Calculate();
            creditManager.Save();

            Customer customer = new Customer();
            customer.Id = 1;
           // customer.FirstName = "Berat Kubilay";
           // customer.LastName = "Artvin";
            //customer.NationalIdendity = "123456";
            customer.City = "Izmir";

            // CustomerManager customerManager = new CustomerManager(); //örneğini oluşturmak, instance oluşturmak (heap de referans oluşturduk)

            CustomerManager customerManager = new CustomerManager(customer);

            customerManager.Save();
            customerManager.Delete();

            Company company = new Company();
            company.TaxNumber = "987654";
            company.CompanyName = "Siemens";
            company.Id = 100;


            CustomerManager customerManager2 = new CustomerManager(new Person());

            Person person = new Person();
            person.FirstName = "";
            person.NationalIdentity = "";


            Customer c1 = new Customer();
            Customer c2 = new Person();
            Customer c3 = new Company();

            Console.ReadLine();
            
        }

    }
       */

    //Interface : İş yapan sınıfların operasyonlarını sadece imza seviyesinde yazarak yazılımda bağımlılığı korumak için yapılan çalışmadır.
    // Bankalardaki kredi türleri örneği gibi düşünebilirim. Tarım kredisi konut kredisi vs.
    class Program
    {
        static void Main(string[] args)
        {

            // IoC Container

            // Bir sınıf sadece bir sınıfı inheritance (miras) edebilir.
            // Bir sınıf birden fazla interface i implement edebilir.

            CustomerManager customerManager = new CustomerManager(new Customer(), new MilitaryCreditManager());

            customerManager.GiveCredit();

            Console.ReadLine();
        }
    }

    class CreditManager
    {
        public void Calculate(int creditType)
        {
            if (creditType == 1) 
            {

            }

            Console.WriteLine("Hesaplandı");
        }
        public void Save()
        {
            Console.WriteLine("Kredi verildi");
        }
    }

    interface ICreditManager
    {
        void Calculate();

        void Save();
    }

    abstract class BaseCreditManager : ICreditManager
    {
        public abstract void Calculate();
      
        public virtual void Save()  //virtual : sanal
        {
            Console.WriteLine("Kaydedildi");
        }
    }


    class TeacherCreditManager :BaseCreditManager, ICreditManager
    {
        public override void Calculate() // override: üstüne yaz demek
        {
            //hesaplamalar
            Console.WriteLine("Öğretmen Kredisi hesaplandı");
        }

        //public override void Save()     >>> Burada öğretmen kredisi save edilirken farklı bir şey görmek istersek nasıl kullanılacağını gösterdik. base ile
        //    base.Save();
        //}

        // DRY ( Kendini tekrarlama) save metodunun içinde gereksiz yere kaydedildi yazdık. Bunun yerine abstract
        //public void Save()
        //{
        //    Console.WriteLine("Kaydedildi"); 
        //}
    }

    class MilitaryCreditManager : BaseCreditManager, ICreditManager
    {
        public override void Calculate()
        {
            Console.WriteLine("Asker Kredisi hesaplandı");
        }

        //public void Save()
        //{
        //    Console.WriteLine("Kaydedildi");
        //}
    }

    //SOLID
    class Customer
    {
        public Customer()
        {
           
            Console.WriteLine("Müşteri Nesnesi Başlatıldı!");
        }

        public int Id { get; set; }
       // public string FirstName { get; set; }

       // public string LastName { get; set; }

       // public string NationalIdendity { get; set; }

       // public string TaxNumber { get; set; }

        public string City { get; set; }

    }
    class Person : Customer
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string NationalIdentity { get; set; }
    }

    class Company : Customer
    {
        public string TaxNumber { get; set; }

        public string CompanyName { get; set; }
    }

    //Katmanlı Mimariler = Görevleri birbirinden ayırıyoruz

    /*
    class CustomerManager
    {
        private Customer _customer;
        public CustomerManager(Customer customer)
        {
            _customer = customer;
        }

        // public void Save(Customer customer) //encapsulation
        public void Save() 
        {
            Console.WriteLine("Müşteri kaydedildi : " + _customer.FirstName);
        }

        public void Delete() 
        {
            Console.WriteLine("Müşteri silindi : " + _customer.FirstName);
        }

    }
    */

    class CustomerManager
    {
        private Customer _customer;

        private ICreditManager _creditManager;
        public CustomerManager(Customer customer, ICreditManager creditManager)  // interface ler referans tiptir! //polimorfizm icreditmanager vs. dediğimiz yerler
        {
            _customer = customer;
            _creditManager = creditManager;
        }

        public void Save()
        {
            Console.WriteLine("Müşteri kaydedildi : " );
        }

        public void Delete()
        {
            Console.WriteLine("Müşteri silindi : " );
        }

        public void GiveCredit()
        {
            _creditManager.Calculate();
            Console.WriteLine("Kredi verildi");
        }

    }

}