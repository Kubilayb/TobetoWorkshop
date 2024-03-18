using OOP2_Example1.Entities;

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


BaseCustomer[] customers = {customer1, customer2, customer3, customer4};

//value types -->int,bool,double...
//referance types --> array, class, interface...

//Polymorphism 
//Base sınıflar inherite edildiği sınıfların referansını tutabiliyor.

foreach(BaseCustomer customer in customers)
{
    Console.WriteLine(customer.CustomerNumber);
}