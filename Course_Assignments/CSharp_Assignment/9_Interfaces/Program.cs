using _9_Interfaces;

class Program
{
    static void Main(string[] args)
    {
        //  IntefacesIntro();   //   refactor ettik


        //Demo();


        ICustomerDal[] customerDals = new ICustomerDal[3]
        {
                new SqlServerCustomerDal(),
                new OracleServerCustomerDal(),
                new MySqlCustomerDal(),

        };
        foreach (var customerDal in customerDals)
        {
            customerDal.Add();
        }






        Console.ReadLine();
    }

    private static void Demo()
    {
        CustomerManager customerManager = new CustomerManager();
        customerManager.Add(new OracleServerCustomerDal());
    }

    private static void IntefacesIntro()
    {
        PersonManager manager = new PersonManager();
        Customer customer = new Customer()
        {
            Id = 1,
            FirstName = "K",
            LastName = "A",
            Address = "izmir"
        };

        Student student = new Student()
        {
            Id = 2,
            FirstName = "K",
            LastName = "K",
            Department = "D"
        };

        manager.Add(student);

        manager.Add(customer);
    }
}
interface IPerson
{
    int Id { get; set; }
    string FirstName { get; set; }
    string LastName { get; set; }
}

class Customer : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string Address { get; set; }
}

class Student : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string Department { get; set; }
}
class Worker : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string Department { get; set; }
}


class PersonManager
{
    public void Add(IPerson person)
    {
        Console.WriteLine(person.FirstName);
    }
}
