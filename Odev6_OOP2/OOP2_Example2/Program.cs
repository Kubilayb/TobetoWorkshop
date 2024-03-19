

using OOP2_Examples._1_Polymorphism;
using OOP2_Examples._2_Inheritance;
using OOP2_Examples._3_GenericType;
using OOP2_Examples._5_Encapsulation;
using static OOP2_Examples._1_Polymorphism.Pants;




PolymorphismWithAbstractClass();
PolymorphismWithVirtualOverride();
Inheritance();
GenericTypeExample();
EncapsulationExample();
KapsullemeOrnegi();


Console.WriteLine("--------------Polymorphism ve Abstract Class Örneği--------------");
static void PolymorphismWithAbstractClass()
{
    TShirt tshirt = new TShirt();
    Pants pants = new Pants();

    tshirt.DisplayInfo();
    pants.DisplayInfo();

    tshirt.Clotes();
    pants.Clotes();
  
}

Console.WriteLine("--------------Polymorphism ve Virtual Override Örneği--------------");

static void PolymorphismWithVirtualOverride()
{
    Elma elma = new Elma();
    Kivi kivi = new Kivi();

    elma.DescriptionLog();
    kivi.DescriptionLog();

}


Console.WriteLine("--------------Inheritance Örneği--------------");

//HomeAppliances

/*
 Inheritance, bir sınıfın başka bir sınıftan türetilmesini ifade eder. 
 Türetilen sınıf, miras aldığı sınıfın tüm özelliklerini ve davranışlarını (alanlar, özellikler, metotlar) miras alır.
 Temel sınıf, miras veren sınıf olarak adlandırılırken, türetilen sınıf ise alt sınıf veya alt sınıf olarak adlandırılır.
*/
static void Inheritance()
{

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
Console.WriteLine("--------------Generic Type Örneği--------------");

   static void GenericTypeExample()
{
    Box<string> stringKutusu = new Box<string>("Merhaba Dünya");
    Box<int> tamSayiKutusu = new Box<int>(42);

    Box<string>.DisplayContent(stringKutusu);
    Box<int>.DisplayContent(tamSayiKutusu);
}



//----------------




static void EncapsulationExample()
{
    BankAccount bankAccount = new BankAccount("Alice Smith", "123456789", 1000);

    Console.WriteLine($"Customer: {bankAccount.CustomerName}");
    Console.WriteLine($"Account Number: {bankAccount.AccountNumber}");
    Console.WriteLine($"Initial Balance: {bankAccount.Balance}");

    bankAccount.Deposit(500);
    bankAccount.Withdraw(200);
    bankAccount.Withdraw(2000); // Attempt to withdraw more than the balance

    Console.ReadLine();
}

static void KapsullemeOrnegi()
{
    BankaHesabi bankaHesabi = new BankaHesabi("Tony Stark", "123456789", 1000);

    Console.WriteLine($"Müşteri: {bankaHesabi.MusteriAdi}");
    Console.WriteLine($"Hesap Numarası: {bankaHesabi.HesapNumarasi}");
    Console.WriteLine($"Başlangıç Bakiyesi: {bankaHesabi.Bakiye} TL");

    bankaHesabi.ParaYatir(500);
    bankaHesabi.ParaCek(200);
    bankaHesabi.ParaCek(2000); // Bakiyeden fazla çekim denemesi

    Console.ReadLine();
}

