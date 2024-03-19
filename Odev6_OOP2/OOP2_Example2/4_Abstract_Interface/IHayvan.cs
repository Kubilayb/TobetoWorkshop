using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_Examples._4_Abstract_Interface
{
    // Arayüz: IHayvan
    interface IHayvan
    {
        // Metot: Ses çıkar
        void SesCikar();
    }

    // Somut sınıf: Köpek
    class Kopek : IHayvan
    {
        // Metodu uygulama
        public void SesCikar()
        {
            Console.WriteLine("Hav hav!");
        }
    }
}

/*
Bu örnekte, IHayvan adında bir interface tanımlanmıştır. 
Bu interface içinde SesCikar adında bir metot bulunmaktadır. 
Daha sonra Kopek adında bir sınıf bu interface'i uygulamıştır. 
Main metodunda ise IHayvan tipinde bir nesne oluşturulmuş ve bu nesne üzerinden SesCikar metodu çağrılmıştır. 
Bu çağrı, aslında Kopek sınıfındaki uygulamayı tetikleyecektir. Bu durumda çıktı olarak "Hav hav!" görülecektir.
*/
