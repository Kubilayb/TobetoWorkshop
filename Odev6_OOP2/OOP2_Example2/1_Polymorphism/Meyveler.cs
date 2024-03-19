using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_Examples._1_Polymorphism
{
    public class Meyveler
    {
        public virtual void DescriptionLog()
        {
            Console.WriteLine("Aciklama yazdirma base'i.");
        }
    }

    public class Elma : Meyveler
    {
        public override void DescriptionLog()
        {
            Console.WriteLine("Elma Elma Elma");
        }
    }

    public class Kivi : Meyveler
    {
        public override void DescriptionLog()
        {
            base.DescriptionLog();
            Console.WriteLine("Kivi Kivi Kivi");
        }
    }
}

/*
 virtual ve override anahtar kelimeleri, .NET platformunda polymorphism'i sağlayan bir mekanizmadır.

virtual: Bu anahtar kelime, bir metodu (DescriptionLog metodu gibi) türetilmiş sınıfların üzerine yazılabilir hale getirir. 
Yani, temel sınıfta tanımlanan bir metodu türetilmiş sınıflar istedikleri takdirde değiştirebilirler. 
Ancak, türetilmiş sınıflar bu metodu değiştirmek zorunda değildir, yani temel sınıfın uygulamasını kullanmaya devam edebilirler. 
virtual anahtar kelimesi, temel sınıfta tanımlanan bir metodu değiştirilebilir hale getirir ve türetilmiş sınıfların bu metodun davranışını değiştirmesine izin verir.

override: Bu anahtar kelime, bir metodu türetilmiş bir sınıfta üzerine yazmak için kullanılır. 
Bir metodu override etmek, temel sınıfta tanımlı olan orijinal uygulamanın yerine, türetilmiş sınıfın kendi uygulamasını kullanmasını sağlar. 
Yani, override anahtar kelimesi, temel sınıfta virtual anahtar kelimesi ile işaretlenmiş bir metodu değiştirmek için kullanılır.

Yukarıdaki kodda, Meyveler sınıfında DescriptionLog metodu virtual olarak işaretlenmiştir. 
Bu, Elma ve Kivi sınıflarında bu metodu gerektiğinde değiştirebileceğimiz anlamına gelir. 
Elma sınıfında, DescriptionLog metodu override edilmiş ve kendi özel uygulaması ile değiştirilmiştir. 
Kivi sınıfında ise, DescriptionLog metodu hem temel sınıfın uygulamasını kullanmak için base.DescriptionLog() çağrısı yapılmış hem de kendi özel uygulaması eklenmiştir. 
Bu sayede, Kivi sınıfı, hem temel sınıfın davranışını hem de kendi özel davranışını birleştirebilir.
 */
