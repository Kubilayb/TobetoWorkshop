
// List aslında bir class 
// class List {}

List<string> sehirler = new List<string>();
sehirler.Add("Ankara");
sehirler.Add("İzmir");
sehirler.Add("İstanbul");
sehirler.Add("Konya");
Console.WriteLine(sehirler.Count);

MyList<string> sehirler2 = new MyList<string>();
sehirler2.Add("Ankara");
sehirler2.Add("İzmir");
sehirler2.Add("İstanbul");
sehirler2.Add("Konya");
sehirler2.Add("Artvin");

Console.WriteLine(sehirler2.Count);

class MyList<T>  // Generic Class  => Bıradaki T tip yani hangi tipi verirsek o çalışıyor.
{
    T[] _array;
    T[] _tempArray;
    public MyList()
    {
        _array = new T[0];
    }

    public void Add(T item)
    {
        T[] _tempArray = _array;

        _array = new T[_array.Length + 1];

        for (int i = 0; i < _tempArray.Length; i++)
        {
            _array[i] = _tempArray[i];
        }
        _array[_array.Length - 1] = item;

    }
    public int Count
    {
        get { return _array.Length; }
    }
}

/*  Generic yapılar, C# dilinde tür belirtmek yerine bir şablon oluşturmanızı sağlar. 
    Bu şablon, farklı türlerle kullanılabilen bir yapı veya metot olabilir.
    Örneğin, bir listeniz varsa ve bu liste hem string'lerle hem de integer'larla çalışabilmeli, 
    aynı zamanda başka bir veri tipiyle de çalışabilir olmalı. 
    İşte bu tür durumlarda generic yapılar kullanılır. */
partial class Program
{
    static void Main(string[] args)
    {
        // Bir string listesi oluşturma
        List<string> stringListesi = new List<string>();
        stringListesi.Add("Merhaba");
        stringListesi.Add("Dünya");

        // Bir integer listesi oluşturma
        List<int> integerListesi = new List<int>();
        integerListesi.Add(1);
        integerListesi.Add(2);
        integerListesi.Add(3);

        // Generic olmayan bir metodun kullanımı
        int toplam = ToplamHesapla(integerListesi);
        Console.WriteLine("Integer Listesi Toplamı: " + toplam);

        // Aynı metodun generic versiyonunun kullanımı
        double ortalama = OrtalamaHesapla(stringListesi);
        Console.WriteLine("String Listesi Ortalaması: " + ortalama);
    }

    // Generic olmayan bir metod
    static int ToplamHesapla(List<int> sayilar)
    {
        int toplam = 0;
        foreach (int sayi in sayilar)
        {
            toplam += sayi;
        }
        return toplam;
    }

    // Generic bir metod
    static double OrtalamaHesapla<T>(List<T> veriler)
    {
        double toplam = 0;
        foreach (T veri in veriler)
        {
            toplam += Convert.ToDouble(veri);
        }
        return toplam / veriler.Count;
    }
}

/* Yukarıdaki örnekte, ToplamHesapla adında bir metodumuz var ve bu metod sadece integer'larla çalışıyor. 
 * Ancak OrtalamaHesapla adında generic bir metodumuz var ve bu metod farklı türlerle çalışabiliyor. 
 * Bu sayede aynı metodu hem string listesiyle hem de integer listesiyle kullanabiliyoruz.*/