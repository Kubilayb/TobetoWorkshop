

// CLASS => Genel anlamda yapmak istediğimiz işlemleri gruplara ayırmak bu grup üzerinden işlemlerimizi yapmak 
// ve rahatlıkla bu gruplara ulaşmak için kullanırız.

using _8_Classes;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // BİR CLASS I KULLANMAK İÇİN ONUN BİR ÖNEĞİNİ OLUŞTURMAK GEREKİR ( NEWLEMEK)
            // referans
            CustomerManager customerManager = new CustomerManager(); // PascalCase camelCase = new PascalCase yazma stili bu
            customerManager.Add();
            customerManager.Update();


            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.City = "izmri";
            customer.FirstName = "Kub";
            customer.LastName = "A";
            customer.Id = 1;

            Customer customer2 = new Customer()
            {
                Id = 2,
                FirstName = "Küb",
                LastName = "K",
                City = "izmir"

            };

            Console.WriteLine(customer.FirstName);
            Console.WriteLine(customer2.FirstName);

            Console.ReadLine();

            // YANİ BURADA HANGİ NESNE İLE ÇALIŞMAK İSTİYORSAK
            // ÖNCE O NESNEYE AİT CLASS I OLUŞTURUYORUZ SONRA İÇİNDEKİ METOTLARI İSTEDİĞİMİZ GİBİ ÇAĞIRIYORUZ
            // BURADAKİ CLASSLARI AYRI KLASÖRLERE ALABİLİYORUZ. 
        }
    }
}


/*    class CustomerManager
    {
    public void Add()
    {
        Console.WriteLine("Customer Added");
    }
    public void Update()
    {
        Console.WriteLine("Customer Updated");
    }
 */












