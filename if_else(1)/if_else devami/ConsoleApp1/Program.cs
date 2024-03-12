/*
Console.WriteLine("---ANA MENÜ---");
Console.WriteLine("1-BAKİYE GÖRÜNTÜLE\n2-PARA ÇEK\n3-PARA YATIR\n4-ÇIKIŞ\n");
Console.Write("Lütfen seçim yapınız:");
int bakiye = 10000;
string choose = Console.ReadLine();
if (choose == "1")
{
    Console.WriteLine("Mevcut bakiyeniz:" + bakiye);
}
else if (choose == "2")
{
    Console.Write("Çekmek istediğiniz tutar:");
    int cek = int.Parse(Console.ReadLine());
    if (cek <= bakiye)
    {
        Console.WriteLine("İşlem başarılı...");
        bakiye -= cek;
        Console.WriteLine("Kalan bakiye:" + bakiye);
    }
    else
        Console.WriteLine("Yetersiz bakiye. Tekrar deneyiniz...");

}
else if (choose == "3")
{
    Console.Write("Yatırılacak tutar:");
    int yatir = int.Parse(Console.ReadLine());
    Console.WriteLine("İşlem başarılı");
    bakiye += yatir;
    Console.Write("Mevcut bakiye:" + bakiye);
}
else if(choose=="4")
    Console.WriteLine("Çıkış başarılı bir şekilde yapıldı...");
else
    Console.WriteLine("Hatalı giriş...");
*/


 double vki;
 
Console.Write("Lutfen gecerli boy degerini giriniz:");
double boy =double.Parse(Console.ReadLine());
Console.Write("Lutfen gecerli kilo degerini giriniz:");
int kilo = int.Parse(Console.ReadLine());

vki = kilo / (boy/100 * boy/100);
Console.WriteLine("Vucut kitle endeksiniz:"+vki);
if (vki <= 18)
    Console.WriteLine("Vucut kitle indeksi normal degerin altındadır.");
else if (vki > 18 && vki < 25)
    Console.WriteLine("Vucut kitle indeksi normal degerdedir.");
else 
    Console.WriteLine("Vucut kitle indeksi normal degerin ustundedir.");
    





















