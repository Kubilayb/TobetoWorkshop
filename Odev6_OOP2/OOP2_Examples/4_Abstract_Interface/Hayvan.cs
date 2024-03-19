using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_Examples._4_Abstract_Interface
{
    // Abstract sınıf: Hayvan
    abstract class Hayvan
    {
        // Abstract metot: Ses çıkar
        public abstract void SesYap();
    }

    // Somut sınıf: Kedi
    class Cat : Hayvan
    {
        // Abstract metodu uygulama
        public override void SesYap()
        {
            Console.WriteLine("Miyav Miyav!");
        }
    }
}
/*
Bu örnekte, Animal adında bir abstract sınıf tanımlanmıştır.
Bu sınıfın içinde SesYap adında bir abstract metot bulunmaktadır.
Daha sonra Cat adında bir sınıf bu abstract sınıftan miras alınmıştır ve SesYap metodu bu sınıfta uygulanmıştır. 
Main metodunda ise Animal tipinde bir nesne oluşturulmuş ve bu nesne üzerinden SesYap metodu çağrılmıştır. 
Bu çağrı, aslında Cat sınıfındaki uygulamayı tetikleyecektir. Bu durumda çıktı olarak "Miyav Miyav!" görülecektir.
*/