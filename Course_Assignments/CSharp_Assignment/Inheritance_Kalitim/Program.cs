

// INHERITANCE KALITIM MİRAS

namespace Inheritance_Kalitim
{
    class Program
    {
        static void Main(string[] args)
        {


            Person[] people = new Person[3]
            {
                new Customer{FirstName="Berat"}, 
                new Student{FirstName="Kubilay"}, 
                new Person{FirstName="K"}
            };

            foreach (Person person in people)
            {
                Console.WriteLine(person.FirstName);
            }

            Console.ReadLine();
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Person2
    {
        public int Id2 { get; set; }
    }

    class Customer : Person  // Person2   burada person 2 yi yazamayız bir sınıfı birkez miras aldırabiliriz.İnterface de alabiliriz.
    {
        public string City { get; set; }
    }
    class Student : Person
    {
        public string Department { get; set; }
    }
}