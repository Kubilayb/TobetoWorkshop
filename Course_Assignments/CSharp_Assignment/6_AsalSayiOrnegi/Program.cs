
/* Asal sayı, yalnızca 1 ve kendisi olmak üzere, sadece iki pozitif böleni olan bir doğal sayıdır. 
 * Örneğin, 2, 3, 5, 7 gibi sayılar asal sayılardır çünkü 
 * yalnızca 1 ve kendilerine bölünebilirler. Ancak, 1 bir asal sayı olarak kabul edilmez, 
 * çünkü yalnızca kendisine bölünebilir ve bu tanıma uymaz. 

*/

class Program
{
    static void Main(string[] args)
    {
        if (isPrimeNumber(6))
        {
            Console.WriteLine("This is a prime number");
        }
        else
        {
            Console.WriteLine("Sorry this is not a prime number!");
        }
        Console.ReadLine();

        static bool isPrimeNumber(int number)
        {
            bool result = true;
            for (int i = 2; i < number - 1; i++)
            {
                if (number % i == 0)
                {
                    result = false;
                    i = number;
                }
            }
            return result;
        }

    }
}