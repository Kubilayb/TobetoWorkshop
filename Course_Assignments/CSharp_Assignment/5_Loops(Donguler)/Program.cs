
// For döngüsü

Console.WriteLine("FOR DÖNGÜSÜ");
Console.WriteLine("-----------");

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}
Console.WriteLine("Bitti");
// ÇIKTI : 1 2 3 4 5 6 7 8 9 10
Console.WriteLine("-----------");

Console.WriteLine("WHILE DÖNGÜSÜ");
Console.WriteLine("-----------");

int number = 5;
while (number >= 0)
{
    Console.WriteLine(number);
    number--;
}
Console.WriteLine("Bitti");
// ÇIKTI : 5 4 3 2 1 0
Console.WriteLine("-----------");

Console.WriteLine("DO WHILE DÖNGÜSÜ");
Console.WriteLine("-----------");

int number1 = 5;
do
{
    Console.WriteLine(number1);
    number1--;
} while (number1>=3);
// ÇIKTI : 5 4 3

Console.WriteLine("-----------");
Console.WriteLine("FOREACH DÖNGÜSÜ");

string[] students = new string[3] { "Berat", "Kubilay", "Kubr" };

foreach (var student in students)
{
    Console.WriteLine($"{student}");
}

Console.ReadLine();
