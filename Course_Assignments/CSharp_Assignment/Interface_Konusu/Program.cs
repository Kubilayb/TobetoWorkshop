

/*
class PersonManager
{

    // implemented operation tamamlanmış operasyon    burada yaptığımız operasyon heryerde ortak demektir
    public void Add()
    {
        Console.WriteLine("Eklendi");

    }
}

class CustomerManager : PersonManager
{

}                           BU KODUN İNTEFACE VERSİYONU

*/



//IPersonManager customerManager = new CustomerManager();


//IPersonManager employeeManager = new EmployeeManager();

ProjectManager projectManager = new ProjectManager();
projectManager.Add(new CustomerManager());

projectManager.Add(new EmployeeManager());

projectManager.Add(new InternManager());    



// NOT: İNTERFACELER NEWLENEMEZ
interface IPersonManager
{
    // unimplemented operation      Buradaki yaptığımız 
    void Add(); // imza
    void Update();
}

// inherits > class -------   intrerface lerde implements

class CustomerManager : IPersonManager
{
    public void Add()
    {
        // Müşteri ekleme kodları
        Console.WriteLine("Müşteri eklendi");

    }

    public void Update()
    {
        Console.WriteLine("Müşteri güncellendi");
    }
}

class EmployeeManager : IPersonManager
{
    public void Add()
    {
        Console.WriteLine("Personel eklendi");
    }

    public void Update()
    {
        Console.WriteLine("Personel güncellendi");
    }
}

class InternManager : IPersonManager
{
    public void Add()
    {
        Console.WriteLine("Stajyer eklendi");
    }

    public void Update()
    {
        Console.WriteLine("Stajtyer güncellendi");
    }
}

class ProjectManager
{
    public void Add(IPersonManager personManager)
    {
        personManager.Add();
    }


}

