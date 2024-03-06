
//Odevler ve Cevapları

//Odev 1:Switch case ile müşteriden alınan sipariş numarasına göre hangi ürünün sipariş edildiğini belirleyen algoritma yazınız.Input için Scanner kullanınız
//Cevap1
Console.WriteLine("Görüntülemek istediğinizin sipariş sepetinizin numarasını giriniz: ");
int orderNumber = Convert.ToInt32(Console.ReadLine());
switch (orderNumber)
{
    case 1:
        Console.WriteLine("1 Numaralı Sipariş Sepetiniz.");
        break;
    case 2:
        Console.WriteLine("2 Numaralı Sipariş Sepetiniz.");
        break;
    case 3:
        Console.WriteLine("3 Numaralı Sipariş Sepetiniz.");
        break;
    case 4:
        Console.WriteLine("4 Numaralı Sipariş Sepetiniz.");
        break;
    case 5:
        Console.WriteLine("5 Numaralı Sipariş Sepetiniz.");
        break;
    default:
        Console.WriteLine("Yanlış Numara Girdiniz!");
        break;
}

