

using OOP2_Examples._1_Polymorphism;
using OOP2_Examples._2_Inheritance;
using OOP2_Examples._2_Inheritance.Entities;
using OOP2_Examples._3_GenericType;
using OOP2_Examples._4_Abstract_Interface;
using OOP2_Examples._5_Encapsulation;
using static OOP2_Examples._1_Polymorphism.Pants;


PolymorphismWithAbstractClass();
PolymorphismWithVirtualOverride();
Inheritance();
GenericTypeExample();
AbstractExample();
InterfaceExample();
KapsullemeOrnegi();


static void PolymorphismWithAbstractClass()
{

    Console.WriteLine("--------------Polymorphism ve Abstract Class Örneği--------------");

    TShirt tshirt = new TShirt();
    Pants pants = new Pants();

    tshirt.DisplayInfo();
    pants.DisplayInfo();

    tshirt.Clotes();
    pants.Clotes();

}


static void PolymorphismWithVirtualOverride()
{
    Console.WriteLine("--------------Polymorphism ve Virtual Override Örneği--------------");


    Elma elma = new Elma();
    Kivi kivi = new Kivi();

    elma.DescriptionLog();
    kivi.DescriptionLog();

}
//---------------------------------------------------------------------------------------------------------



//HomeAppliances

/*
 Inheritance, bir sınıfın başka bir sınıftan türetilmesini ifade eder. 
 Türetilen sınıf, miras aldığı sınıfın tüm özelliklerini ve davranışlarını (alanlar, özellikler, metotlar) miras alır.
 Temel sınıf, miras veren sınıf olarak adlandırılırken, türetilen sınıf ise alt sınıf veya alt sınıf olarak adlandırılır.
*/
static void Inheritance()
{
    Console.WriteLine("--------------Inheritance Örneği--------------");


    IndividualCustomer customer1 = new IndividualCustomer();
    customer1.Id = 1;
    customer1.FirstName = "Tony";
    customer1.LastName = "Start";
    customer1.NationalIdentity = "124567";
    customer1.CustomerNumber = "16579871";
    customer1.Address = "İstanbul";

    IndividualCustomer customer2 = new IndividualCustomer();
    customer2.Id = 2;
    customer2.FirstName = "Bruce";
    customer2.LastName = "Wayne";
    customer2.NationalIdentity = "1234568";
    customer2.CustomerNumber = "4548425";
    customer2.Address = "Ankara";

    CorporateCustomer customer3 = new CorporateCustomer();
    customer3.Id = 3;
    customer3.Name = "Marvel";
    customer3.TaxNumber = "123456";
    customer3.CustomerNumber = "3456621";
    customer3.Address = "İzmir";

    CorporateCustomer customer4 = new CorporateCustomer();
    customer4.Id = 4;
    customer4.Name = "DC";
    customer4.TaxNumber = "174785";
    customer4.CustomerNumber = "5788795";
    customer4.Address = "Konya";


    BaseCustomer[] customers = { customer1, customer2, customer3, customer4 };

    //value types -->int,bool,double...
    //referance types --> array, class, interface...

    //Polymorphism 
    //Base sınıflar inherited edildiği sınıfların referansını tutabiliyor.

    foreach (BaseCustomer customer in customers)
    {
        Console.WriteLine(customer.CustomerNumber);
    }

    Console.WriteLine("--------------Inheritance Örneği--------------");

    Television television1 = new Television();
    television1.Id = 1;
    television1.Name = "Vestel";
    television1.Description = "Smart TV";
    television1.ModelYear = 2023;
    television1.Price = 20.000;
    television1.ResolutionQuality = " 4K QLED";
    television1.TVSize = "55 inches";

    Television television2 = new Television();
    television2.Id = 2;
    television2.Name = "Samsung";
    television2.Description = "Android TV";
    television2.ModelYear = 2022;
    television2.Price = 19.000;
    television2.ResolutionQuality = " 4K OLED";
    television2.TVSize = "50 inches";

    WashingMachine washingMachine1 = new WashingMachine();
    washingMachine1.Id = 3;
    washingMachine1.Name = "Bosch";
    washingMachine1.Description = "Yabancı Çamaşır Makinesi";
    washingMachine1.ModelYear = 2022;
    washingMachine1.Price = 8000;
    washingMachine1.MaxKg = "9 KG";
    washingMachine1.SpinSpeedRpm = 1400;

    WashingMachine washingMachine2 = new WashingMachine();
    washingMachine2.Id = 4;
    washingMachine2.Name = "Arçelik";
    washingMachine2.Description = "Yerli Çamaşır Makinesi";
    washingMachine2.ModelYear = 2019;
    washingMachine2.Price = 6500;
    washingMachine2.MaxKg = "8 KG";
    washingMachine2.SpinSpeedRpm = 1200;

    Television[] televisions = { television1, television2 };

    WashingMachine[] washingMachines = { washingMachine1, washingMachine2 };

    for (int i = 0; i < televisions.Length; i++)
    {
        Console.WriteLine(televisions[i].Name + " " + televisions[i].Description + " " + televisions[i].ResolutionQuality);

    }

    for (int i = 0; i < washingMachines.Length; i++)
    {
        Console.WriteLine(washingMachines[i].Name + " " + washingMachines[i].MaxKg + " " + washingMachines[i].SpinSpeedRpm);
    }
}

//---------------------------------------------------------------------------------------------------------

static void GenericTypeExample()
{
    Console.WriteLine("--------------Generic Type Örneği--------------");


    Box<string> stringKutusu = new Box<string>("Merhaba Dünya");
    Box<int> tamSayiKutusu = new Box<int>(42);

    Box<string>.DisplayContent(stringKutusu);
    Box<int>.DisplayContent(tamSayiKutusu);
}

//---------------------------------------------------------------------------------------------------------
static void AbstractExample()
{
    Console.WriteLine("--------------Abstract Örneği--------------");

    // Hayvan sınıfından türetilen nesne
    Hayvan hayvan = new Cat();

    // Hayvanın sesini çıkarma
    hayvan.SesYap();

}


static void InterfaceExample()
{

    Console.WriteLine("--------------interface Örneği--------------");

    // IHayvan arayüzünden türetilen nesne
    IHayvan hayvan = new Kopek();

    // Hayvanın sesini çıkarma
    hayvan.SesCikar();

}

//---------------------------------------------------------------------------------------------------------
    static void KapsullemeOrnegi()
    {
        Console.WriteLine("--------------Encapsulation Örneği--------------");

        Hesap kullaniciHesabi = new Hesap("Kubilay", "sifre123");

        // Kullanıcı adı ve şifresini gösterme
        Console.WriteLine("Kullanıcı Adı: " + kullaniciHesabi.KullaniciAdi);
        Console.WriteLine("Şifre: " + kullaniciHesabi.Sifre);
    }




