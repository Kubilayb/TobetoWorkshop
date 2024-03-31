

namespace InterfacesDemo
{


    //  SRP(Tek Sorumluluk Prensibi) : Bir sınıfın yalnızca bir nedeni olmalıdır değişiklik yapmaya.

    //  OCP(Açık/Kapalı Prensibi): Sınıflar, genişletilmeye açık ancak değişime kapalı olmalıdır.

    //  LSP(Liskov Yerine Geçme Prensibi): Alt sınıflar, üst sınıfların yerine kullanılabilmelidir.

    //  ISP(Arayüz Ayrımı Prensibi): İstemciler, ihtiyaç duymadıkları arayüz metotlarını kullanmamalıdır.

    //  DIP(Bağımlılıkların Ters Çevrilmesi Prensibi): Yüksek seviyeli modüller, düşük seviyeli modüllere bağımlı olmamalıdır.
    //  Her ikisi de soyutlamalara bağlı olmalıdır.




    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
            new Manager(),
            new Worker(),
            new Robot()
            };

            foreach (var worker in workers)
            {
                worker.Work();
            }

            // SOLID prensiplerinden i Harfi => Interface Segregation yaptık.

            IEat[] eats = new IEat[2]
            {
                new Worker(),
                new Manager()
            };
        }
    }


    //      ÇOKLU İMPLEMENTASYON
    interface IWorker
    {
        void Work();

    }
    interface IEat
    {
        void Eat();
    }
    interface ISalary
    {
        void GetSalary();

    }
    class Manager : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Çalışan yemek yedi");
        }

        public void GetSalary()
        {
            Console.WriteLine("Çalışan maaş aldı");
        }

        public void Work()
        {
            Console.WriteLine("Çalışıyor");
        }
    }

    class Worker : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Çalışan yemek yedi");
        }

        public void GetSalary()
        {
            Console.WriteLine("Çalışan maaş aldı");
        }

        public void Work()
        {
            Console.WriteLine("Çalışıyor");
        }
    }
    class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Çalışıyor");
        }
    }

}


