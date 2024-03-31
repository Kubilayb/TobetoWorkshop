

// Stringler birer char arraydir.

string city = "izmir";
//Console.WriteLine(city[0]);


foreach (var item in city)
{
    Console.WriteLine(item);
}


string city2 = "konya";
string result1 = city + city2;  // result = sonuç
Console.WriteLine(result1);

Console.WriteLine("--------------");
// 16.satırdaki koda alternatif daha iyi yani best practice

Console.WriteLine("{0} {1}", city, city2);

Console.WriteLine("**--**--**--**");


string sentence = "My name is Berat Kubilay";      //sentence = cümle 

var result = sentence.Length;    // Length => Boşluklar dahil kaç karakter olduğunu gösterir.
Console.WriteLine(result);
var result2 = sentence.Clone();   // Clone => String değerin yani cümlemizin bir referansını daha oluşturmaya yarar.

sentence = "My name is Kuby";
Console.WriteLine(result2);

bool result3 = sentence.EndsWith("y");      // EndWith  => Bu cümle hangi karakter ile bitiyor True False dönüyor.
Console.WriteLine(result3);

bool result4 = sentence.StartsWith("M");    // StartsWith  => Bu cümle hangi karakter ile başlıyor True False dönüyor.
Console.WriteLine(result4);

var result5 = sentence.IndexOf("name");     // IndexOf => Bir string de belli bir karakteri aramaya yarıyor.
Console.WriteLine(result5);                 // Name kaçıncı karakterden başlıyor mesela 3  Yanlış ifade varsa -1 döner.

var result6 = sentence.IndexOf(" ");        // Boşluk karakterini ararsak çoğu yerde bulunduğu için ilk bulduğu boşluğu sayar.
Console.WriteLine(result6);                 // 0 1 2 = 2 yi döner     

var result7 = sentence.LastIndexOf(" ");    // LastIndexOf => Sondan başlayarak sayar ilk bulduğu andaki yeri sayar.
Console.WriteLine(result7);

var result8 = sentence.Insert(0, "Hello, ");    // Insert => Bir string ifadeye başka bir metin eklemeye yarıyor.
Console.WriteLine(result8);                     // Sıfırıncı karakterden itibaren hello boşluk bir karakter ekle.

var result9 = sentence.Substring(3, 4);     // Substring => Metni parçalamak için kullanılır
Console.WriteLine(result9);                 // Bu örnekte 3,4 yani 3.karakterden sonraki 4. karakteri al burada boşluğuda sayıp Name i alır

var result10 = sentence.ToLower();          // ToLower => Tüm karakterleri küçük harfle yazar.
Console.WriteLine(result10);

var result11 = sentence.ToUpper();          // ToUpper => Tüm karakterleri büyük harfle yazar.
Console.WriteLine(result11);

var result12 = sentence.Replace(" ","-");   // Replace=> Bir metin içindeki belli karakterleri değiştirmek için kullanılır.
Console.WriteLine(result12);                // Boşluk yerine çizgi kullandık.

var result13 = sentence.Remove(2,4);          //Remove => 2. ifadeden sonrasını silmek istiyorum gibi kullanılabilir.
Console.WriteLine(result13);                // Sadece My ifadesi kalır. Ya da 2,4 yazarsak sadece my dan sonraki 4 ifadeyi kaldırır.



