using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOP2_Examples._1_Polymorphism;


//Abstract Ana sınıf: Giysi
public abstract class ClothingItems
{
    public abstract void DisplayInfo();
    public void Clotes()
    {
        Console.WriteLine("Giysiler Sergileniyor");
    }
}
// Alt sınıf: Tişört
public class TShirt : ClothingItems
{
    public override void DisplayInfo()
    {
        Console.WriteLine("Tişörtler");
    }
}

// Alt sınıf: Pantolon
public class Pants : ClothingItems
{
    public override void DisplayInfo()
    {
        Console.WriteLine("Pantolonlar.");
    }
}
/*
Bu kodda, ClothingItems adında soyut bir sınıf tanımlanmıştır. 
Bu sınıf, DisplayInfo adında bir soyut metot içerir ve ayrıca Clothes adında bir somut metot bulunur.

TShirt ve Pants sınıfları, ClothingItems sınıfından türetilmiştir. 
Her iki sınıf da soyut metodu (DisplayInfo) uygular ve kendi giysi bilgilerini yazdırır.

Bu yapı, polymorphism kullanarak farklı giysi tiplerini temsil eder. 
Abstract class kullanılması, giysi tiplerinin ortak davranışlarını tanımlamak için 
uygun bir yol sunar ve her bir giysi türünün özelliklerine göre davranmasını sağlar. */
