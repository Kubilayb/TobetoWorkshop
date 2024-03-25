// Value Types
// integer bir değer tipidir.(value type)

int number1 = 10;   //32 bit
long number2 = 12165156135;  //64 bit
short number3 = -12315; //16 bit
byte number4 = 255; //8 bit
bool sart = false;
char karakter = 'A';
double number5 = 11.5; // ondalık için kullanılır 64 bit
decimal number6 = 19.9m; // para birimi için kullanılabilir.
var number7 = 10;
number7 = 'A';
//number7 = "A"; hata verir

Console.WriteLine("Number1 is {0}", number1);
Console.WriteLine("Number2 is {0}", number2);
Console.WriteLine("Number3 is {0}", number3);
Console.WriteLine("Number4 is {0}", number4);
Console.WriteLine("Character is : {0}", (int)karakter);
Console.WriteLine("Number5 is {0}", number5);
Console.WriteLine("Number6 is {0}", number6);
Console.WriteLine("Number7 is {0}", number7);

Console.WriteLine(Days.friday);
Console.WriteLine((int)Days.friday);

enum Days
{
    // 0      1         2          3       4         5        6
    monday, tuesday, wednesday, thursday, friday, saturday, sunday
}