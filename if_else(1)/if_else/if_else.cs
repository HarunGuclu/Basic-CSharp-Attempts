//using System;
//class Starting
//{
//    static void Main()
//    {

//        Console.WriteLine("Hello, World!");
//        string name = "Harun";
//        Console.WriteLine("my name is {0}",name);
//        Console.WriteLine($"my name is {name}");
//        int num1; int num2; int sum;
//        Console.Write("birinci sayıyı girin:");
//        num1=int.Parse(Console.ReadLine());
//        Console.Write("ikinci sayıyı girin:");
//        num2=int.Parse(Console.ReadLine());
//        sum = num1 + num2;
//        Console.Write($"girdiğiniz sayıların toplammı {sum}");

//    }
//}





/*
//        ÖDEV 
float num1; float num2; float sum;  int choose;
Console.Write("birinci sayıyı girin:");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("ikinci sayıyı girin:");
num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Toplama için 1\nÇıkarma için 2\nÇarpma için 3\nBölme için 4\n");
choose = int.Parse(Console.ReadLine());
if (choose == 1)
{
    sum = num1 + num2;
    Console.Write($"Sonuç={sum}");
}
else if (choose == 2)
{
    sum = num1 - num2;
    Console.Write($"Sonuç={sum}");
}
else if (choose == 3)
{
    sum = num1 * num2;
    Console.Write($"Sonuç={sum}");
}
else if (choose == 4)
{

    if (num2 == 0)
    {
        Console.Write("Sıfıra bölme hatası!");
    }
    else
    {

        sum = num1 / num2;
        Console.Write($"Sonuç={sum}");
    }

}

*/
/*
//       ÖDEV-2
int num1; int num2; int num3;   int num4;
Console.Write("1. sayıyı giriniz:");
num1 = int.Parse(Console.ReadLine());
Console.Write("2. sayıyı giriniz:");
num2 = int.Parse(Console.ReadLine());
Console.Write("3. sayıyı giriniz:");
num3 = int.Parse(Console.ReadLine());
Console.Write("4. sayıyı giriniz:");
num4 = int.Parse(Console.ReadLine());

if (num1 > num2 && num1 > num3 && num1 > num4)
{
    if (num2 > num3 && num2 > num4)
    { if (num3 > num4)
            Console.Write($"{num1}>{num2}>{num3}>{num4}");
        else
            Console.Write($"{num1}>{num2}>{num4}>{num3}");
    }
    else if (num3 > num2 && num3 > num4)
    {
        if (num2 > num4)
            Console.Write($"{num1}>{num3}>{num2}>{num4}");
        else
            Console.Write($"{num1}>{num3}>{num4}>{num2}");

    }
    else if (num4 > num2 && num4 > num3)
    {
        if (num2 > num3)
            Console.Write($"{num1}>{num4}>{num2}>{num3}");
        else
            Console.Write($"{num1}>{num4}>{num3}>{num2}");
    }

}
else if (num2 > num1 && num2 > num3 && num2 > num4)
{
    if (num1 > num3 && num1 > num4)
    {
        if (num3 > num4)
            Console.Write($"{num2}>{num1}>{num3}>{num4}");
        else
            Console.Write($"{num2}>{num1}>{num4}>{num3}");
    }
    else if (num3 > num1 && num3 > num4)
    {
        if (num1 > num4)
            Console.Write($"{num2}>{num3}>{num1}>{num4}");
        else
            Console.Write($"{num2}>{num3}>{num4}>{num1}");
    }
    else if (num4 > num1 && num4 > num3)
    {
        if (num1 > num3)
            Console.Write($"{num2}>{num4}>{num1}>{num3}");
        else
            Console.Write($"{num2}>{num4}>{num3}>{num1}");
    }
}
else if (num3 > num1 && num3 > num2 && num3 > num4)
{
    if (num1 > num2 && num1 > num4)
    {
        if (num2 > num4)
            Console.Write($"{num3}>{num1}>{num2}>{num4}");
        else
            Console.Write($"{num3}>{num1}>{num4}>{num2}");
    }
    else if (num2 > num1 && num2 > num4)
    {
        if (num1 > num4)
            Console.Write($"{num3}>{num2}>{num1}>{num4}");
        else
            Console.Write($"{num3}>{num2}>{num4}>{num1}");
    }
    else if (num4 > num1 && num4 > num2)
    {
        if (num1 > num2)
            Console.Write($"{num3}>{num4}>{num1}>{num2}");
        else
            Console.Write($"{num3}>{num4}>{num2}>{num1}");
    }
}
else
{
    if (num1 > num2 && num1 > num3)
    {
        if (num2 > num3)
            Console.Write($"{num4}>{num1}>{num2}>{num3}");
        else
            Console.Write($"{num4}>{num1}>{num3}>{num2}");
    }
    else if (num2 > num1 && num2 > num3)
    {
        if (num1 > num3)
            Console.Write($"{num4}>{num2}>{num1}>{num3}");
        else
            Console.Write($"{num4}>{num2}>{num3}>{num1}");
    }
    else
    { 
        if(num2> num1)
            Console.Write($"{num4}>{num3}>{num2}>{num1}");
        else
            Console.Write($"{num4}>{num3}>{num1}>{num2}");

    }
}
*/


/*
        //        ÖDEV-3
int cocuk1; int cocuk2; int cocuk3; int adet; int ucret; int toplam = 0; string cinsiyet;
Console.Write("Kaç tane çocuğunuz var:");
adet = int.Parse(Console.ReadLine());
Console.WriteLine("Birinci çocuğun yaşı:");
cocuk1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ikınci çocuğun yaşı:");
cocuk2 = int.Parse(Console.ReadLine());
Console.WriteLine("Üçüncü çocuğun yaşı:");
cocuk3 = int.Parse(Console.ReadLine());
if (cocuk1 < 6)
{
    ucret = 0;
    toplam = toplam + ucret;
    
    
}
else if (6 <= cocuk1 && cocuk1 <= 12)
{
    Console.WriteLine(" Birici çocuğun cinsiyeti(e-k):");
    cinsiyet = Console.ReadLine();
    if (cinsiyet == "e")
    {
        ucret = 70;
        toplam = toplam + ucret;
    }
    else
    {
        ucret = 60;
        toplam = toplam + ucret;
    }
}

else
{
    Console.WriteLine(" Birinci çocuğun cinsiyeti(e-k):");
    cinsiyet = Console.ReadLine();
    if (cinsiyet == "e")
    {
        ucret = 130;
        toplam = toplam + ucret;
    }
    else
    {
        ucret = 120;
        toplam = toplam + ucret;
    }
}
if (cocuk2 < 6)
{
    Console.WriteLine(" İkinci çocuğun cinsiyeti(e-k):");
    cinsiyet = Console.ReadLine();
    if (cinsiyet == "e")
    {
        ucret = 0;
        toplam = toplam + ucret;
    }
    else
    {
        ucret = 0;
        toplam = toplam + ucret;
    }
}
else if (6 <= cocuk2 && cocuk2 <= 12)
{
    Console.WriteLine(" İkinci çocuğun cinsiyeti(e-k):");
    cinsiyet = Console.ReadLine();
    if (cinsiyet == "e")
    {
        ucret = 70;
        toplam = toplam + ucret;
    }
    else
    {
        ucret = 60;
        toplam = toplam + ucret;
    }
}
else
{
    Console.WriteLine(" İkinci çocuğun cinsiyeti(e-k):");
    cinsiyet = Console.ReadLine();
    if (cinsiyet == "e")
    {
        ucret = 130;
        toplam = toplam + ucret;
    }
    else
    {
        ucret = 120;
        toplam = toplam + ucret;
    }
}
if (cocuk3 < 6)
{
    Console.WriteLine(" Üçüncü çocuğun cinsiyeti(e-k):");
    cinsiyet = Console.ReadLine();
    if (cinsiyet == "e")
    {
        ucret = 0;
        toplam = toplam + ucret;
    }
    else
    {
        ucret = 0;
        toplam = toplam + ucret;
    }
}
else if (6 <= cocuk3 && cocuk3 <= 12)
{
    Console.WriteLine(" Üçüncü çocuğun cinsiyeti(e-k):");
    cinsiyet = Console.ReadLine();
    if (cinsiyet == "e")
    {
        ucret = 70;
        toplam = toplam + ucret;
    }
    else
    {
        ucret = 60;
        toplam = toplam + ucret;
    }
}
else
{
    Console.WriteLine(" Üçüncü çocuğun cinsiyeti(e-k):");
    cinsiyet = Console.ReadLine();
    if (cinsiyet == "e")
    {
        ucret = 130;
        toplam = toplam + ucret;
    }
    else
    {
        ucret = 120;
        toplam = toplam + ucret;
    }
}
toplam = toplam + 240;
Console.WriteLine($"Ödemeniz gereken ücret:{toplam}");
*/
/*
double money;
Console.Write("please enter the salary information:");
money= Convert.ToInt32(Console.ReadLine());
if (money>0 && money<=1000)

    money = money * 0.005;

else if(money>1000 && money<=10000)

    money = money * 0.1;

else if(money>10000 && money<25000)

    money = money * 0.15;

else
    money = money * 0.2;

Console.WriteLine("the amount of tax to be paid:" + money);
*/
//------------------------------------------------
//Console.WriteLine("---ANA MENÜ---");
//Console.WriteLine("1-BAKİYE GÖRÜNTÜLE\n2-PARA ÇEK\n3-PARA YATIR\n4-ÇIKIŞ\n");
//Console.Write("Lütfen seçim yapınız:");
//int bakiye = 10000;
//string choose = Console.ReadLine();
//if (choose == "1")
//{
//    Console.WriteLine("Mevcut bakiyeniz:" + bakiye);
//}
//else if (choose == "2")
//{
//    Console.Write("Çekmek istediğiniz tutar:");
//    int cek = int.Parse(Console.ReadLine());
//    if (cek <= bakiye)
//    {
//        Console.WriteLine("İşlem başarılı...");
//        bakiye -= cek;
//        Console.WriteLine("Kalan bakiye:" + bakiye);
//    }
//    else
//        Console.WriteLine("Yetersiz bakiye. Tekrar deneyiniz...");

//}
//else if (choose == "3")
//{
//    Console.Write("Yatırılacak tutar:");
//    int yatir = int.Parse(Console.ReadLine());
//    Console.WriteLine("İşlem başarılı");
//    bakiye += yatir;
//    Console.Write("Mevcut bakiye:" + bakiye);
//}
//else if (choose == "4")
//    Console.WriteLine("Çıkış başarılı bir şekilde yapıldı...");
//else
//    Console.WriteLine("Hatalı giriş...");
//-------------------------------------------------