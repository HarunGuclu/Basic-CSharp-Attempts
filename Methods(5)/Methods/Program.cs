using System.Diagnostics.Metrics;
using System.Reflection;

class Methods
{
    class Program
    {
        static void Main()
        {
            //abs(x) : mutlak değer alır
            //ceiling(x) : tavan değere yani kendinden sonraki en büyük tamsayı değerine yuvarlar.
            //floor(x) : taban değere yani kendinden sonraki en küçük tamsayı değerine yuvarlar.
            //exp(x) : e^x değerini alır.
            //-------------------------------------
            //double max, min, n1, n2, n3;
            //Console.Write("3 tane sayı girin:");
            //n1 = double.Parse(Console.ReadLine());
            //n2 = double.Parse(Console.ReadLine());
            //n3 = double.Parse(Console.ReadLine());
            //max = Math.Max(n1, n2);
            //if (max > n3)
            //    Console.WriteLine("Max:" + Math.Round(max,2));
            //else
            //    Console.WriteLine("Max:" + Math.Round(n3,2));
            //min = Math.Min(n1, n2);
            //if (min < n3)
            //    Console.WriteLine("Min:" + Math.Round(min,2));
            //else
            //    Console.WriteLine("Min:" + Math.Round(n3,2));
            //-------------------------------------
            //int count1=0, count2=0, count3 = 0, count4 = 0, count5 = 0, count6 = 0;
            //for (int i=0; i < 20; i++)
            //{
            //    int and;
            //    Random rand = new Random();
            //    and = rand.Next(1,7);      
            //    Console.Write(and+" ");
            //    if (and == 1)
            //        count1++;
            //    else if (and == 2)
            //        count2++;
            //    else if (and == 3)
            //        count3++;
            //    else if (and == 4)
            //        count4++;
            //    else if (and == 5)
            //        count5++;
            //    else if  (and == 6)
            //        count6++;
            //    else
            //        Console.WriteLine("Error!");

            //}
            //Console.WriteLine("\nn1:" + count1);
            //Console.WriteLine("n2:" + count2);
            //Console.WriteLine("n3:" + count3);
            //Console.WriteLine("n4:" + count4);
            //Console.WriteLine("n5:" + count5);
            //Console.WriteLine("n6:" + count6);
            //----------------------------------
            //double count1 = 0, count2 = 0, count3 = 0, count4 = 0, count5 = 0, count6 = 0;
            //for (int i = 0; i < 200000; i++)
            //{
            //    int and;
            //    Random rand = new Random();
            //    and = rand.Next(1, 7);
            //    //Console.Write(and + " ");
            //    if (and == 1)
            //        count1++;
            //    else if (and == 2)
            //        count2++;
            //    else if (and == 3)
            //        count3++;
            //    else if (and == 4)
            //        count4++;
            //    else if (and == 5)
            //        count5++;
            //    else if (and == 6)
            //        count6++;
            //    else
            //        Console.WriteLine("Error!");

            //}
            //Console.WriteLine("\nn1:" +  Math.Round(count1/200000,5));
            //Console.WriteLine("n2:" +    Math.Round(count2/200000,5));
            //Console.WriteLine("n3:" + Math.Round(count3 / 200000, 5));
            //Console.WriteLine("n4:" + Math.Round(count4 / 200000, 5));
            //Console.WriteLine("n5:" + Math.Round(count5 / 200000, 5));
            //Console.WriteLine("n6:" + Math.Round(count6 / 200000, 5));
            //-----------------------------------------------
            //Random random=new Random();
            //int rnd = 0,sum=0;
            //for (int i=0;i<=15;i++)
            //{
            //    rnd=random.Next(5,151);
            //    Console.Write(rnd+" ");
            //    if (rnd % 2 == 0)
            //        sum += rnd;
            //}
            //Console.WriteLine($"\nResult:{sum}");
            //-------------------------------------------

            //Random random = new Random();
            //int rnd = random.Next(1,101);
            //while (true)
            //{
            //    Console.WriteLine("ENTER 1 NUMBER BETWEEN 1-100:");
            //    int n1 = int.Parse(Console.ReadLine());
            //    if (n1 == rnd)
            //    { 
            //    Console.WriteLine("Congratulations!");
            //    break;
            //    }
            //    else if (n1 < rnd)
            //        Console.WriteLine("Please enter a larger number.");
            //    else
            //        Console.WriteLine("Please enter a smaller number.");

            //}
            //---------------------------------------------------
            //Random rand = new Random();
            //for (int i = 0; i < 7; i++)
            //{
            //    int rnd = rand.Next(0, 10);
            //    Console.WriteLine($"{i + 1}. lucky number:{rnd}");
            //}
            //-----------------------------------------------

            //---------METODLAR(FONKSİYONLAR)---------
            //-------------------------------------
            //sum();
            //static void sum()
            //{
            //    int n1=int.Parse(Console.ReadLine());
            //    int n2=int.Parse(Console.ReadLine());
            //    Console.WriteLine("The sum:"+(n1+n2));
            //}
            //--------------------------------------------

            //Console.WriteLine(take_square());

            //static double take_square()
            //{
            //    Console.Write("Enter one number:");
            //    double take = int.Parse(Console.ReadLine());
            //    return Math.Pow(take,2);  //take*take;
            //}

            //--------------------------------------------

            //area();
            //static void area()
            //{
            //    double area;
            //    Console.Write("Enter the base length:");
            //    double len= double.Parse(Console.ReadLine());
            //    Console.Write("Enter the height length:");
            //    double height = double.Parse(Console.ReadLine());
            //    area = (len * height)/2;
            //    Console.WriteLine("Area:" + area);
            //}

            //--------------------------------------------

            //Console.WriteLine("Enter first number:");
            //int f1 =int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter second number:");
            //int s1 = int.Parse(Console.ReadLine());

            //big(f1,s1);

            //static void big(int f1,int s1)
            //{
            //    if (f1 > s1)
            //    {
            //        Console.WriteLine(f1 + ">" + s1);
            //    }
            //    else
            //    {
            //        Console.WriteLine(s1 + ">" + f1);
            //    }
            //}

            //--------------------------------------------

            //double unit_price, discount;
            //Console.Write("enter the unit price of the product:");
            //unit_price=double.Parse(Console.ReadLine());

            //Console.Write("enter the discount rate:");
            //discount = double.Parse(Console.ReadLine());

            //double x = price(unit_price, discount);
            //Console.WriteLine("the discounted price of the product is:" +x);
            //static double price(double a, double b)
            //{
            //    a -= a*(b / 100);
            //    return a;   
            //}

            //--------------------------------------------

            //int k1, k2, k3;
            //Console.Write("enter the first edge:");
            //k1 = int.Parse(Console.ReadLine());
            //Console.Write("enter the second edge:");
            //k2 = int.Parse(Console.ReadLine());
            //Console.Write("enter the third edge:");
            //k3 = int.Parse(Console.ReadLine());
            //findtriangle(k1, k2,  k3);
            //static void findtriangle(int s1,int  s2,int  s3)
            //{
            //    if (s1 == s2 && s2 == s3)
            //    {
            //        Console.WriteLine("Equilateral triangle");
            //    }
            //    else if (s1 != s2 && s1 != s2 && s1 != s3)
            //    {
            //        Console.WriteLine("Scalene triangle");
            //    }
            //    else
            //    {
            //        Console.WriteLine("isosceles triangle");
            //    }

            //}
            //--------------------------------------------

            //int edge1, edge2;
            //Console.Write("enter the first edge of the right triangle:");
            //edge1 = int.Parse(Console.ReadLine());
            //Console.Write("enter the second edge of the right triangle:");
            //edge2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("hypotenuse length:" + right_triangle(edge1, edge2));

            //static double right_triangle(int s1, int s2)
            //{
            //    double hypotenuse;
            //    hypotenuse = Math.Sqrt(s1 * s1 + s2 * s2);
            //    return hypotenuse;
            //}

            //--------------------------------------------
            
        }
    }
   
}


