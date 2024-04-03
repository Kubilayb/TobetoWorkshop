

Customer customer1 = new Customer { Id = 1, FirstName = "Ad", LastName = "Soyad", City = "izmir" };

Customer customer3 = new Customer();
customer3.Id = 3;


Customer customer2 = new Customer(2, "BeratK", "Artvin", "izmir");


class Customer
{
    public Customer()  // ctor yaz tab a bas default constructor
    {

    }

    public Customer(int ıd, string firstName, string lastName, string city)
    {
        Id = ıd;
        FirstName = firstName;
        LastName = lastName;
        City = city;
    }

    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string City { get; set; }
}






