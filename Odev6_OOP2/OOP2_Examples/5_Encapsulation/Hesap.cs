using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_Examples._5_Encapsulation
{
    class Hesap
    {
        private string _kullaniciAdi;
        private string _sifre;

        public Hesap(string kullaniciAdi, string sifre)
        {
            _kullaniciAdi = kullaniciAdi;
            _sifre = sifre;
        }

        public string KullaniciAdi
        {
            get { return _kullaniciAdi; }
            set { _kullaniciAdi = value; }
        }

        public string Sifre
        {
            get { return _sifre; }
            set { _sifre = value; }
        }
    }
}


/* Bu kodda:

Bir Hesap sınıfı tanımlanır ve _kullaniciAdi ve _sifre adında private alanlar oluşturulur.
Bir kurucu metot kullanılarak bu alanlar hesap nesnesi oluşturulurken başlatılır.
_kullaniciAdi ve _sifre alanlarına erişimi kapsüllenmiş hale getirmek için KullaniciAdi ve Sifre adında özellikler (properties) oluşturulur.
Main metodu içinde, bir kullanıcı hesabı oluşturulur ve kullanıcı adı "Kubilay", şifre "sifre123" olarak belirlenir. 
Daha sonra bu bilgiler özellikler aracılığıyla gösterilir. Bu, doğrudan alanlara erişimi kısıtlayarak kapsüllemenin bir örneğidir.

*/