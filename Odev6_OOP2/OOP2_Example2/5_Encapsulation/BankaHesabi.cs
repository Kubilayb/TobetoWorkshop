using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_Examples._5_Encapsulation
{
    public class BankaHesabi
    {
        private string musteriAdi;
        private string hesapNumarasi;
        private decimal bakiye;

        public string MusteriAdi
        {
            get { return musteriAdi; }
            set { musteriAdi = value; }
        }

        public string HesapNumarasi
        {
            get { return hesapNumarasi; }
            private set { hesapNumarasi = value; }
        }

        public decimal Bakiye
        {
            get { return bakiye; }
            private set { bakiye = value; }
        }

        public BankaHesabi(string musteriAdi, string hesapNumarasi, decimal ilkBakiye)
        {
            this.musteriAdi = musteriAdi;
            this.hesapNumarasi = hesapNumarasi;
            this.bakiye = ilkBakiye;
        }

        public void ParaYatir(decimal miktar)
        {
            if (miktar > 0)
            {
                bakiye += miktar;
                Console.WriteLine($"{miktar} TL yatırıldı. Güncel bakiye: {bakiye} TL");
            }
            else
            {
                Console.WriteLine("Geçersiz yatırma miktarı.");
            }
        }

        public void ParaCek(decimal miktar)
        {
            if (miktar > 0 && miktar <= bakiye)
            {
                bakiye -= miktar;
                Console.WriteLine($"{miktar} TL çekildi. Güncel bakiye: {bakiye} TL");
            }
            else
            {
                Console.WriteLine("Geçersiz çekme miktarı veya yetersiz bakiye.");
            }
        }
    }
}
