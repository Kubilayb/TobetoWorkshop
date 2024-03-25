class Program
{
    static void Main(string[] args)
    {
        // if else if else

        var number = 91;

        if (number == 10)
        {
            Console.WriteLine("Number is 10");
        }
        else if (number == 20)
        {
            Console.WriteLine("Number is 20");
        }
        else
        {
            Console.WriteLine("Number is not 10 or 20");
        }
        //reSharper eklentisi ile 
        // Console.WriteLine(number == 10 ? "Number is 10" : "Number is not 10");

        // switch
        
        switch (number)
        {
            case 30: 
                Console.WriteLine("Number is 30");
                break;
            case 20:
                Console.WriteLine("Number is 40");
                break;
            default:
                Console.WriteLine("Number is not 30 or 40");
                break;
        }
        

        if (number >= 0 && number <= 100) // ve operatörü
        {
            Console.WriteLine("Number is between 0-100");
        }
        else if (number > 100 && number <= 200)
        {
            Console.WriteLine("Number is between 101-200");
        }
        else if (number > 200 || number < 0) // veya operatörü
        {
            Console.WriteLine("Number less than 0 or greater than 200");
        }

        // iç içe sorgu yazabiliriz.
        if (number < 100)
        {
            if (number >= 90)
            {
                Console.WriteLine("90'dan büyük ya da eşit.");
            }
            else
            {
                Console.WriteLine("90'dan küçük");
            }
        }
        Console.ReadLine();


    }
}