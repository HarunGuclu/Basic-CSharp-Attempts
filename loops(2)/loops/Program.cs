using System;
using System.Security.Cryptography;


class Program
{
    static void Main()
    {
        /*
         
        int sayac = 0;
        while (sayac <= 10)
        {
            Console.Write($"{sayac} ");
            sayac++;
        }
        */

        //------------------------------------

        /*
        for(int i=1; i<=10; i++)
        {
            Console.Write($"{i}. sırada {i}\n");
        }
        */

        //------------------------------------

        /*
        int i = 1, total=0;
        while (i<=20)
        {
            total = total + i;    //total+=i;
            i++;
        }
        Console.Write($"Sayıların toplamı:{total}");
        */

        //--------------------------------------

        /*
        int total = 0;
        for(int i=0;i<=20;i++)
        {
            total += i;
        }
        Console.Write($"Toplam={total}");
        */

        //---------------------------------------

        /*
        int i = 0, sum = 0;
        while(i<=20)
        {
            sum += i;
            i += 2;
        }
        Console.Write($"ciftlerin toplamı:{sum}");
        */

        //--------------------------------------


        /*
        int i = 1, sum = 0;
        while(i<=20)
        {
            sum += i;
            i+=2;
        }
        Console.Write($"Teklerin toplamı:{sum}");
        */

        //--------------------------------------

        /*
        int sum = 0;
        for(int i =0;i<=20; i+=2)
        {
            sum += i;
        }
        Console.Write($"Ciftlerin toplamı:{sum}");
        */

        //----------------------------------

        /*
        int total = 0;
        for(int i=1; i<=20; i+=2)
        {
            total += i;
        }
        Console.Write($"Teklerin toplamı:{total}");
        */

        //-------------------------------------------

        /*
        // 10 YILLIK FAİZ HESAPLAMA
        double money = 10000;
        double faiz = 0.05;
        for (int i =1;i<=10;i++)
        {
            money = money + money * faiz;
            Console.WriteLine($"{i}. yıl faiz toplamı:{money}");
        }
        */

        //-------------------------------------------

        /*
        
        int x = 1;
        int num;
        Console.WriteLine("Enter 10 numbers");
        for (int i =0;i<10;i++)
        {
            Console.Write($"{i+1}.number:");
            num = int.Parse(Console.ReadLine());
            if((num%2==1) &&( num>0))
            {
                x*=num;
            }
        }
        Console.Write($"the sum of odd and positive numbers:{x}");
        */

        //-------------------------------------------


        /*
        
        int i = 0, num, sum=0;
        Console.WriteLine("Enter 10 numbers");
        while (i<10)
        {
            Console.Write($"{i+1}. numbers:");
            num = Convert.ToInt32(Console.ReadLine());
            sum += num;
            i++;
        }
        Console.WriteLine(sum);
        */

        //------------------------------------------

        /*
        
        string name;
        for(int i=1; i<=10; i++)
        {
            Console.Write("What is your name:");
            name = Console.ReadLine();
            Console.WriteLine(i+".name:" + name);
        }
        */

        //-----------------------------------------

        /*
        
        int num=1;
        while (num<=100)
        {
            if (num%5==0 || num%7==0)
            {
                Console.Write(num+" ");
            }
            num++;
        }

        */

        //--------------------------------

        /*
         
        Console.WriteLine("Enter two numbers");
        int n1, n2;
        n1 = int.Parse(Console.ReadLine());
        n2 = int.Parse(Console.ReadLine());
        for(int i= n1;i<=n2;i++)
        {
            Console.Write(i + " ");
        }
        */

        //-----------------------------------


        /*
        
        Console.WriteLine("Enter two numbers");
        int n1, n2;
        n1 = int.Parse(Console.ReadLine());
        n2 = int.Parse(Console.ReadLine());
        if(n1<n2)
            for (int i = n1; i <= n2; i++)
            {
                Console.Write(i + " ");
            }
        else
        {
            for (int i = n1; i >= n2; i--)
            {
                Console.Write(i + " ");
            }
        }
        */

        //---------------------------------------

        /*
         
        Console.WriteLine("Enter five numbers");
        int n1,count=0;
        
        
        for (int i = 0; i < 5; i++)
        {
            n1 = int.Parse(Console.ReadLine());
            if (n1 > 10 && n1 < 20)
                count++;
        }
        Console.WriteLine($"{count} of them are between 10-20");
        */

        //------------------------------------

        /*
        
        for (int i = 0; i <=10;i++ )
        {
            for (int j = 0; j <= 10; j++)
            {
                Console.WriteLine($"{i} X {j} = {i * j}");
            }
            Console.WriteLine("\n");
        }
        */

        //------------------------------------

        /*
        
        int bigNumber=0, smallNumber=0, n=0;
        for (int i=0; i < 10; i++)
        {

            n=Convert.ToInt32(Console.ReadLine());
            smallNumber = n;
            if(n>bigNumber)
                bigNumber=n;
            else if(n<smallNumber)
                smallNumber=n;
        }
        Console.WriteLine("Big number is "+ bigNumber);
        Console.WriteLine("Small number is "+ smallNumber);
        */

        //-------------------------------------------

        /*
        
        Console.WriteLine("Enter two numbers");
        int n1, n2, sum=0;
        n1 = int.Parse(Console.ReadLine());
        n2 = int.Parse(Console.ReadLine());
        for(int i=n1+1;i<n2;i++)
        {
              sum += i;
        }
        Console.WriteLine(sum);
        */

        //-------------------------------

        /*
       
        Console.WriteLine("Kaç kişinin vergisi hesaplanacak");
        int kisi=int.Parse(Console.ReadLine());
        double maas=0;
        for (int i = 0; i < kisi; i++)
        {
            Console.Write($"{i + 1}. kişinin maaşı:");
            maas = double.Parse(Console.ReadLine());
            if (maas <= 0)
            { 
            Console.WriteLine("Hatalı değer");
            break;
            }   
            else if (maas < 1000)
            {
                maas = maas * 0.1;
                Console.WriteLine($"{i + 1}. kişinin vergisi:{maas}");
            }
            else if (maas >= 1000 && maas < 25000)
            {
                maas = maas * 0.15;
                Console.WriteLine($"{i + 1}. kişinin vergisi:{maas}");
            }
            if (maas >=25000)
            {
                maas = maas * 0.2;
                Console.WriteLine($"{i + 1}. kişinin vergisi:{maas}");
            }
        }
        */

        //-------------------------------------------------

        /*
        
        int i = 1;
        double maas;
        double toplamvergi=0;
        while (true)
        {
            Console.Write($"{i}.kişinin maaşı(çıkış için -1'e basın):");
            maas=double.Parse(Console.ReadLine());
            if (maas == -1)
                break;
            else if (maas <=8000)
            {
                maas = maas * 0.1;
                Console.WriteLine($"{i}. kişinin vergisi:{maas}");
                toplamvergi += maas;
            }
            else if (maas > 8000&& maas <=20000)
            {
                maas = maas * 0.15;
                Console.WriteLine($"{i}. kişinin vergisi:{maas}");
                toplamvergi += maas;
            }
            else if (maas > 20000)
            {
                maas = maas * 0.2;
                Console.WriteLine($"{i}. kişinin vergisi:{maas}");
                toplamvergi += maas;
            }
            i++;
            Console.WriteLine($"Toplam vergi tutarı:{toplamvergi}");
        }
        */

        //---------------------------------------

        /*
        for (int i = 0; i < 1; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.WriteLine(new string('*', j));
            }
        }
        */

        //---------------------------------------

        /*
        for (int i = 10; i >= 1; i--)
        {
            for (int j = 0; j < 1; j++)
            {
                Console.WriteLine(new String('*' , i));
            }
        }

        */

        //---------------------------------------

        /*
        for(int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                
                Console.Write(j);
                
            }
            Console.WriteLine("\n");
            
        }
        */

        //---------------------------------------

        /*
        string user = "guclu";
        string pass = "guclu123";
        
        for (int i = 3; i >= 1; i--)
        {
            Console.Write("Please enter your username:");
            string username = Console.ReadLine();

            Console.Write("Please enter your password:");
            string password = Console.ReadLine();
            if (username == user&& password==pass)
            {
                Console.WriteLine("Entry successful.");
                break;
            }
            else 
            {
                Console.WriteLine($"You have {i} chances left.Try again...");

            }
        }
        */

        //---------------------------------------

        /*
        string usrnme = "batman";
        string paswrd = "batman123";
        int i = 3;
        while (i >= 1)
        {
            Console.Write("Please enter your username:");
            string usname = Console.ReadLine();
            Console.Write("Please enter your password:");
            string psword = Console.ReadLine();
            if (paswrd == psword)
            {
                Console.WriteLine("Entry successful.");
                break;

            }
            else
            {
                i--;
                Console.WriteLine($"You have {i} chances left.Try again...");
            }
        }
        */

        //---------------------------------------

        /*
        double avg=0,sum=0;
        Console.Write("How many numbers to enter:");
        double n1=double.Parse(Console.ReadLine());

        for(int i=0;i<n1;i++)
        {
            Console.Write("Please enter "+(i+1)+". number:");
            double n2 = double.Parse(Console.ReadLine());
            sum+=n2;
            avg=sum/n1;
        }
        Console.WriteLine("The average:"+ avg);
        Console.WriteLine("the sum of the numbers is:"+sum);
        */

        //---------------------------------------

        /*
        int num,num1, sum = 0;


        Console.Write("How many numbers will you enter:");
        num = Convert.ToInt32(Console.ReadLine());
        for(int i = 0; i < num; i++)
        {
            Console.Write($"{i+1}. number:");
            num1= Convert.ToInt32(Console.ReadLine());
            sum += num1;
        }
        Console.WriteLine("The sum:"+sum);
        */

        //---------------------------------------

        /*
        int n,n1, sumodd=0, oddcounter=0, sumeven=0, evencounter=0;
        Console.Write("How many numbers will you enter:");
        n = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write($"{i + 1}. number:");
            n1 = Convert.ToInt32(Console.ReadLine());
            if(n1%2==0)
            {
                sumeven += n1;
                evencounter++;

            }
            else
            {
                sumodd += n1;
                oddcounter++;
            }
        }
        Console.WriteLine($"number of odd numbers: {oddcounter} sum of odd numbers: {sumodd}");
        Console.WriteLine($"number of evennumbers: {evencounter} sum of even numbers: {sumeven}");
        
        */

        //---------------------------------------

       
    }

}
