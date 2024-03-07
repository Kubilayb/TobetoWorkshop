
// Sorular ve Cevapları

Console.WriteLine("Merhaba ben Berat Kubilay Artvin (Pair 4).\nBu konsol uygulamasında .Net eğitimimin ilk ödevinin soru ve cevalarını göreceksiniz.\nBaşlamak için'ENTER' tuşuna basınız.");
Console.ReadLine();

// Soru 1: Switch case ile müşteriden alınan sipariş numarasına göre hangi ürünün sipariş edildiğini belirleyen algoritma yazınız.Input için Scanner kullanınız.

Console.WriteLine("Soru 1:Switch case ile müşteriden alınan sipariş numarasına göre hangi ürünün sipariş edildiğini belirleyen algoritma yazınız.\nInput için Scanner kullanınız.");
Console.WriteLine("-----------------------------");
// Cevap 1:
Console.WriteLine("Görüntülemek istediğinizin sipariş sepetinizin numarasını giriniz: ");
int orderNumber = Convert.ToInt32(Console.ReadLine());
switch (orderNumber)
{
    case 1:
        Console.WriteLine("1 Numaralı Sipariş Sepetiniz. (ELMA...)");
        break;
    case 2:
        Console.WriteLine("2 Numaralı Sipariş Sepetiniz. (ARMUT...)");
        break;
    case 3:
        Console.WriteLine("3 Numaralı Sipariş Sepetiniz. (ERİK...)");
        break;
    case 4:
        Console.WriteLine("4 Numaralı Sipariş Sepetiniz. (ÇİLEK...)");
        break;
    case 5:
        Console.WriteLine("5 Numaralı Sipariş Sepetiniz. (PORTAKAL...)");
        break;
    default:
        Console.WriteLine("Yanlış Numara Girdiniz!");
        break;
}

Console.WriteLine("*************************************************");

/* Soru 2: Kullanıcıdan kaç ürün almak istediğini soran,her ürünün 
fiyatını alarak toplam alışveriş tutarını hesaplayan bir 
algoritma yazınız.(Input için Scanner ve döngü için for döngüsü kullanınız) */

Console.WriteLine("Soru 2: Kullanıcıdan kaç ürün almak istediğini soran,\n her ürünün fiyatını alarak toplam alışveriş tutarını hesaplayan bir algoritma yazınız.\n(Input için Scanner ve döngü için for döngüsü kullanınız)");
Console.WriteLine("-----------------------------");

// Cevap 2:

Console.WriteLine("-------------------------------");
Console.WriteLine("Kaç Adet Ürün Almak İstersiniz?: ");
int urunSayisi = Convert.ToInt32(Console.ReadLine());
double toplamTutar = 0;

for (int i = 1; i <= urunSayisi; i++)
{
    Console.WriteLine(i + ".Ürünün fiyatını giriniz: ");
    toplamTutar += Convert.ToDouble(Console.ReadLine());
}
Console.WriteLine("Toplam alışveriş tutarı: " + toplamTutar);


Console.WriteLine("*************************************************");

// Soru 3: Do-While ve While döngüsü nedir? Bununla ilgili örnek yapınız.

Console.WriteLine("Soru 3: Do-While ve While döngüsü nedir? Bununla ilgili örnek yapınız.");
// Cevap 3:

Console.WriteLine("Do-While ve While döngüleri, belirli bir koşul sağlandığı sürece bir bloğu tekrar tekrar çalıştırmak için kullanılan yapısal programlama elemanlarıdır. \r\n   Bunlar, program akışını kontrol etmek ve belirli bir koşul gerçekleşene kadar tekrarlayan işlemleri gerçekleştirmek için yaygın olarak kullanılır.");
/* Do-While ve While döngüleri, belirli bir koşul sağlandığı sürece bir bloğu tekrar tekrar çalıştırmak için kullanılan yapısal programlama elemanlarıdır. 
   Bunlar, program akışını kontrol etmek ve belirli bir koşul gerçekleşene kadar tekrarlayan işlemleri gerçekleştirmek için yaygın olarak kullanılır. */

Console.WriteLine("Do-While döngüsü kullanarak 0'dan 9'a kadar olan sayıları ekrana yazdırma");
// Do-While döngüsü kullanarak 0'dan 9'a kadar olan sayıları ekrana yazdırma
Console.WriteLine("-->>-->>-->>--");

int sayac = 0;

do
{
    Console.WriteLine(sayac);
    sayac++;
} while (sayac < 10);



Console.WriteLine("*************************************************");

/* Soru 4:Kullanıcının 1 ile 10 arasında rastgele bir sayıyı tahmin 
etmesini isteyen ve doğru tahmin edene kadar devam eden bir program yazınız.
(While döngüsü ile yapınız ve rastgele sayı üretmek için Random sınıfını kullanınız) */

Console.WriteLine("Soru 4:Kullanıcının 1 ile 10 arasında rastgele bir sayıyı tahmin \r\netmesini isteyen ve doğru tahmin edene kadar devam eden bir program yazınız.\r\n(While döngüsü ile yapınız ve rastgele sayı üretmek için Random sınıfını kullanınız)");
Console.WriteLine("-----------------------------");

// Cevap 4:

// Random sınıfı kullanarak rastgele bir sayı oluşturma
Random rand = new Random();
int rastgeleSayi = rand.Next(1, 11); // 11 e kadar yaptık çünkü 1-10 arası rakam istiyoruz

int tahmin = 0;

while (tahmin != rastgeleSayi)
{
    Console.Write("Aklınızdan 1 ile 10 arasında bir sayı tutunuz ve o sayıyı yazınız: ");
    tahmin = Convert.ToInt32(Console.ReadLine());

    if (tahmin < 1 || tahmin > 10)
    {
        Console.WriteLine("HATA! HATA! HATAAA! Lütfen 1 ile 10 arasında başka bir sayı girin.");
        continue; 
    }

    if (tahmin == rastgeleSayi)
    {
        Console.WriteLine("Tebrikler! Doğru tahmin ettiniz. Sayı: " + rastgeleSayi);
    }
    else
    {
        Console.WriteLine("Yanlış tahmin. Tekrar deneyin.");
    }
}

Console.WriteLine("*************************************************");


// Soru 5:Bir sayının mükemmel sayı olup olmadığı kontrol eden algoritma yazınız.
// Öncelikle mükemmel sayının ne olduğuna bakalım.
// Mükemmel sayı, kendisi hariç bütün pozitif bölenlerinin toplamı kendisine eşit olan sayılara mükemmel sayı denir.
// 6 bir mükemmel sayıdır. Çünkü 6’nın pozitif bölenleri 1,2,3 ve 6’dır. Kendisi hariç diğer bölenlerini toplarsak 1+2+3=6 eder.

Console.WriteLine("Soru 5:Bir sayının mükemmel sayı olup olmadığı kontrol eden algoritma yazınız.\r\nÖncelikle mükemmel sayının ne olduğuna bakalım.\r\nMükemmel sayı, kendisi hariç bütün pozitif bölenlerinin toplamı kendisine eşit olan sayılara mükemmel sayı denir.\r\n6 bir mükemmel sayıdır. Çünkü 6’nın pozitif bölenleri 1,2,3 ve 6’dır. Kendisi hariç diğer bölenlerini toplarsak 1+2+3=6 eder.");
Console.WriteLine("-----------------------------");
// Cevap 5:


Console.Write("Mükemmel bir sayı giriniz bakalım mükemmel mi :D \nBir sayı giriniz: ");
int sayi = Convert.ToInt32(Console.ReadLine());

int toplam = 0;

for (int i = 1; i < sayi; i++)
{
    if (sayi % i == 0)
    {
        toplam += i;
    }
}

if (toplam == sayi)
{
    Console.WriteLine(sayi + " mükemmel bir sayıdır.");
}
else
{
    Console.WriteLine(sayi + " mükemmel bir sayı değildir.");
}


Console.WriteLine("*************************************************");

// Soru 6: String metotlarını araştırınız. Her bir metot için örnek yapınız.

Console.WriteLine("Soru 6: String metotlarını araştırınız. Her bir metot için örnek yapınız.");
Console.WriteLine("-----------------------------");

// Cevap 6:

Console.WriteLine("6.Soruya devam etmek için enter tuşuna basın");
Console.ReadLine();

Console.WriteLine("Length: Bir dizenin uzunluğunu (karakter sayısını) döndürür.\nMesela İzmir kelimesinin uzunluğunu öğrenelim.\nİ-Z-M-İ-R");

string kelime1 = "İzmir";
int uzunluk = kelime1.Length;
Console.WriteLine("Kelimenin uzunluğu: " + uzunluk);

Console.WriteLine("-----------------------------");

Console.WriteLine("ToUpper ve ToLower: Dizginin tüm karakterlerini büyük veya küçük harfe dönüştürür.\nTobeto kelimesini büyük ve küçük karakter hallerini görelim.");

string kelime2 = "Tobeto";
string buyukHarf = kelime2.ToUpper();
string kucukHarf = kelime2.ToLower();
Console.WriteLine("Büyük harf: " + buyukHarf);
Console.WriteLine("Küçük harf: " + kucukHarf);

Console.WriteLine("-----------------------------");

Console.WriteLine("Substring: Belirli bir dizgi içinden belirtilen başlangıç ​​konumundan başlayarak bir alt dizgi döndürür.\nİstanbul Kodluyor kelimesindeki İstanbul'u kaldıralım.");

string kelime3 = "İstanbul Kodluyor ";
string altDizi = kelime3.Substring(9); 
Console.WriteLine("Alt dizi: " + altDizi);

Console.WriteLine("-----------------------------");

Console.WriteLine("IndexOf ve LastIndexOf: Belirli bir alt dizenin dizginin içindeki ilk ve son pozisyonunu döndürür.");
Console.WriteLine("'tobeto' kelimesindeki 'b' harfinin ilk bulunduğu index sırasını\n ve 'o' harfinin son bulunduğu index sırasını görelim.");

string kelime4 = "tobeto";
int ilkIndex = kelime4.IndexOf("b"); 
int sonIndex = kelime4.LastIndexOf("o"); 
Console.WriteLine("İlk index: " + ilkIndex); 
Console.WriteLine("Son index: " + sonIndex);

Console.WriteLine("-----------------------------");

Console.WriteLine("Replace: Belirli bir karakterin veya alt dizginin, \nbaşka bir karakter veya alt dizeyle değiştirilmiş bir kopyasını döndürür.\nTobeto kelimesinin 'e' ve 'o' harflerini değiştirelim");

string kelime5 = "Tobeto";
string yeniKelime = kelime5.Replace("e", "o");
Console.WriteLine("Yeni kelime: " + yeniKelime);

Console.WriteLine("-----------------------------");

Console.WriteLine("Concat: İki veya daha fazla dizgiyi birleştirir.\nAdımı ve soyadımı bir arada yazalım");

string ad = "Berat Kubilay";
string soyad = "Artvin";
string adSoyad = String.Concat(ad, " ", soyad);
Console.WriteLine("Ad ve Soyad: " + adSoyad); 

Console.WriteLine("-----------------------------");

Console.WriteLine("Trim: Dizginin başındaki ve sonundaki boşlukları kaldırır.");

string kelime6 = "   ToBeTo   ";
string duzgunKelime = kelime6.Trim();
Console.WriteLine("Boşluklu kelime:" + kelime6);
Console.WriteLine("Boşluksuz düzgün kelime:" + duzgunKelime);

Console.WriteLine("-----------------------------");

Console.WriteLine("Split: Dizgiyi belirli bir ayırıcıya göre böler ve bir diziye yerleştirir.");

string metin = "İstanbul Kodluyor Eğitimi Başladı";
string[] kelimeler = metin.Split(' ');
foreach (string kelime in kelimeler)
{
    Console.WriteLine("Kelime: " + kelime);
}


Console.WriteLine("*************************************************");

/* Soru 7: Kullanıcıdan öğrenci sayısını isteyen her öğrenci için 
    öğrenci adı, öğrenci soyadı,1.sınav notu,2.sınav notu,3.sınav notu isteyen ve daha sonra 
    not ortalamasını hesaplayıp ekrana yazdıran algoritma yapınız.(For döngüsü kullanınız) */

Console.WriteLine("Soru 7: Kullanıcıdan öğrenci sayısını isteyen her öğrenci için \r\n    öğrenci adı, öğrenci soyadı,1.sınav notu,2.sınav notu,3.sınav notu isteyen ve daha sonra \r\n    not ortalamasını hesaplayıp ekrana yazdıran algoritma yapınız.(For döngüsü kullanınız)");

// Cevap 7: 

Console.Write("Lütfen öğrenci sayısını giriniz:  ");
int ogrenciSayisi = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < ogrenciSayisi; i++)
{
    Console.WriteLine($"Öğrenci {i + 1}");

    Console.Write("Öğrencinin adı: ");
    string adi = Console.ReadLine();

    Console.Write("Öğrencinin soyadı: ");
    string soyadi = Console.ReadLine();

    Console.Write("1. sınav notu: ");
    double s1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("2. sınav notu: ");
    double s2 = Convert.ToDouble(Console.ReadLine());

    Console.Write("3. sınav notu: ");
    double s3 = Convert.ToDouble(Console.ReadLine());

    double ortalama = (s1 + s2 + s3) / 3;

    Console.WriteLine($"Not ortalaması: {ortalama}\n");
}
Console.WriteLine("*************************************************");

Console.WriteLine("Sorular ve cevaplar bitmiştir. Teşekkürler");

