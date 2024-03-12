using System.ComponentModel.DataAnnotations;

class Program
 {
     static void Main()
    {
        //----------------------------------

        /*
        int bb, ob, yb;
        for (int i = 1; i < 999; i++)
        {
            if (i < 10)
            {
                if (i == Math.Pow(i, 3))
                {
                    Console.WriteLine(i);
                }
            }
                
            else if (i<100)
            {
                    bb = i % 10;
                    ob= (i % 100)/10;
                    if(i==(Math.Pow(bb, 3)+Math.Pow(ob,3)))
                    { 
                        Console.WriteLine(i);
                    }
            }
            else
            {
                    bb = i % 10;
                    ob = (i % 100) / 10;
                    yb= (i % 1000)/100;
                    if (i == (Math.Pow(bb, 3) + Math.Pow(ob, 3)+Math.Pow(yb,3)))
                    {
                        Console.WriteLine(i);
                    }
            }            
        }

         */

        //-------------------------------------------

        /*
        int num, sum=0;

        Console.Write("Enter number:");
        num=int.Parse(Console.ReadLine());
        string stringnum = Convert.ToString(num);
        for (int i = 0; i < stringnum.Length; i++)
        {
            
            sum += (num % 10) ;
            num /= 10;
           
        }
        Console.WriteLine(sum);

        */

        //-------------------------------------------

        /*
        int sum = 0;

        int[] nums = new int[10];

        for (int i = 0; i < nums.Length; i++)
        {
            Console.Write($"fill the array\n{i}. index:");
            nums[i]=int.Parse(Console.ReadLine());
        }
        foreach (int j in nums)
        {
            sum += j;
        }
        Console.WriteLine("Sum:"+sum);

        */

        //-------------------------------------------

        /*
        int n,bigNumber=0,sumPositive=0,sumNegative=0,smallNumber=0;

        Console.Write("How many elements does the array have?:");
        n=Convert.ToInt32(Console.ReadLine());
        int[] numArray=new int[n];
        for (int i = 0; i < numArray.Length; i++)
        {
            numArray[i]=int.Parse(Console.ReadLine());  
        }
        smallNumber = numArray[0];
        bigNumber = numArray[0];
        for (int j = 0; j < numArray.Length; j++)
        {

            if (numArray[j] < smallNumber)
            {
                smallNumber = numArray[j];
            }
                   
            else if (numArray[j] > bigNumber)
            {
                bigNumber = numArray[j];
            }





            if (numArray[j] <0)
                sumNegative += numArray[j];
            else
            {
                sumPositive += numArray[j];
            }
        }

        Console.WriteLine("The big number in array:"+bigNumber);
        Console.WriteLine("The small number in array:" + smallNumber);
        Console.WriteLine("The sum of the positive numbers in the array is:"+sumPositive);
        Console.WriteLine("The sum of the negative numbers in the array is:" + sumNegative);


        */

        //-------------------------------------------

        /*
        int num,fact=1 ;
        Console.Write("Enter number for factorial:");
        num=int.Parse(Console.ReadLine());
        for (int i = 1; i <= num; i++)
        {
            fact*=i;
        }
        Console.WriteLine($"{num}! = {fact}");

        */

        //-------------------------------------------

        /*

        static int t(int x)
        {
            if (x == 0)
                return 0;
            return x + t(x - 1);

        }
        Console.WriteLine(t(11));

        */

        //-------------------------------------------

        /*

        static int f(int x)
        {
            return 2+5 *x;
        }
        static int g(int y)
        {
            return y*3;
        }
        static int h(int z)
        {
            return z * z;
        }
        Console.WriteLine(f(g(h(3))));

        */

        //-------------------------------------------

        /*
        int[] barchart = { 1, 2, 4, 6, 2, 4, 6, 2, 7, 8, 4, 1, 3, 2, 5, 3, 3 };
        foreach (int i in barchart)
        {
            string stars=new string('*',i);
            Console.WriteLine(stars);
        }

        */

        //-------------------------------------------

        /*
        int _random, counter1 = 0, counter2 = 0, counter3 = 0, counter4 = 0, counter5 = 0, counter6 = 0 ;
        Random random = new Random();
        

        for (int i=0;i<6000000;i++)
        {
            _random=random.Next(1, 7);
            if (_random == 1)
            {
                counter1++;
            }
            else if (_random == 2)
            {
                counter2++;
            }
            else if (_random == 3)
            {
                counter3++;
            }
            else if (_random == 4)
            {
                counter4++;
            }
            else if (_random == 5)
            {
                counter5++;
            }
            else if(_random == 6)
                counter6++;
        }
        Console.WriteLine("Frequency 1 :"+counter1);
        Console.WriteLine("Frequency 2 :"+counter2);
        Console.WriteLine("Frequency 3 :"+counter3);
        Console.WriteLine("Frequency 4 :"+counter4);
        Console.WriteLine("Frequency 5 :"+counter5);
        Console.WriteLine("Frequency 6 :"+counter6);
       
        */

        //-------------------------------------------

        
     }
}