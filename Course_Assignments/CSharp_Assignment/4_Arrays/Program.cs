

Console.WriteLine("TEK BOYUTLU DİZİ");
Console.WriteLine("----------------------");


// 0       1         2       
string[] students = new string[3]{ "Berat", "Kubilay", "Kubr" };

// string[] students = new string[3] { "Berat", "Kubilay", "Kubr", 4 }; buraya 4 yazamayız string dedik çünkü int olamaz

string[] students2 =  { "Berat", "Kubilay", "Kubr" };
students[0] = "Berat";
students[1] = "Kubilay";
students[2] = "Kubr";


foreach (var student in students)  // Arrayleri gezmek için kullanıyoruz.
{
    Console.WriteLine(student);
}

Console.WriteLine("----------------------");
Console.WriteLine("ÇOK BOYUTLU DİZİ");


string[,] regions = new string[7, 3]
{
    {"İstanbul","Edirne","Çanakkale"}, 
    {"Ankara","Konya","Kayseri"}, 
    {"Antalya","Hatay","Osmaniye"}, 
    {"Artvin","Samsun","Ordu"},
    {"İzmir","Muğla","Aydın"},
    {"Gaziantep","Şanlıurfa","Adıyaman"},
    {"Erzurum","Ardahan","Iğdır"}
};

for (int i = 0; i <= regions.GetUpperBound(0); i++)
{
    for (int j = 0; j <= regions.GetUpperBound(1); j++)
    {
        Console.WriteLine(regions[i,j]);
    }
    Console.WriteLine("*****");
}

Console.ReadLine();
