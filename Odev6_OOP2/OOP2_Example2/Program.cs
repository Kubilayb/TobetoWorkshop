





using OOP2_Examples._2_Inheritance;










Console.WriteLine("--------------Inheritance Örneği--------------");

//HomeAppliances

/*
 Inheritance, bir sınıfın başka bir sınıftan türetilmesini ifade eder. 
 Türetilen sınıf, miras aldığı sınıfın tüm özelliklerini ve davranışlarını (alanlar, özellikler, metotlar) miras alır.
 Temel sınıf, miras veren sınıf olarak adlandırılırken, türetilen sınıf ise alt sınıf veya alt sınıf olarak adlandırılır.
*/

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

WashingMachine[] washingMachines = {washingMachine1, washingMachine2 };

for (int i = 0; i < televisions.Length; i++)
{
    Console.WriteLine(televisions[i].Name + " " + televisions[i].Description + " " + televisions[i].ResolutionQuality);
    
}

for (int i = 0;i < washingMachines.Length;i++)
{
    Console.WriteLine(washingMachines[i].Name + " " + washingMachines[i].MaxKg + " " + washingMachines[i].SpinSpeedRpm);
}

Console.WriteLine("--------------Generic Type Örneği--------------");




