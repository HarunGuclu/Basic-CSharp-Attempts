using System;
using System.Globalization;
using System.Windows;

class Program
{

    static void Main(string[] args)
    {
        /*
        
        //------------------------
        List<string> list = new List<string>{"malik", "ahmad", "mohammad", "aisha", "karem", "sam"};
        list.Add("tony");
        list.Add("erica");

        foreach (string s in list)
        {
            Console.Write(s+" ");
        }
        //----------------------
        Console.WriteLine();

        list.Sort();
        for (int i = 0; i < list.Count; i++)
        {
            Console.Write(list[i]+" ");
        }

        Console.WriteLine();
        //-------------------------
        int count = list.Count;
        Console.WriteLine(count);
        //--------------------

        list.Remove("mohammad");// Removed Mohammad

        for (int i = 0; i < list.Count; i++)
        {
            Console.Write(list[i] + " ");
        }
        Console.WriteLine();
        //---------------------
        list.Insert(2, "moussa");
        foreach (string s in list)
        {
            Console.Write(s + " ");
        }
        Console.WriteLine(  );
        //---------------------------
        List<string> NewList = new List<string> { "salah","lionel","frank","ally"};
        list.AddRange(NewList);
        list.RemoveAt(4);//Karem removed
        for (int i = 0; i < list.Count; i++)
        {
            Console.Write(list[i]+" ");
        }
        //-----------------------------
        Console.WriteLine(  );
        Console.WriteLine(list.Contains("frank")); // true or false
        //-----------------------
        int index = list.IndexOf("salah");
        Console.WriteLine("Salah's index:"+index);
        //----------------------
        list.Reverse();
        foreach (string i in list)
        {
            Console.Write(i+" ");
        }
        Console.WriteLine();
        //----------------------------
        
        Console.WriteLine();
        list.Clear();//list cleared
        

        List<int> nums = new List<int> { 2,34,53,6,67,54,32,54,678,34,55};

        nums.Sort();
        foreach(int i in nums)
        {
            Console.WriteLine(i);
        }

        int index_=nums.BinarySearch(12);//Returns the index number of the searched value of the sorted list.(Sıralanmış listede aranan değerin indeks numarasını döndürür.Yoksa negatif döndürür)

        Console.WriteLine(index_);

        //--------------------------
        List<int> nums = new List<int>();
        for(int i = 0; i < 40; i++)
        {
            nums.Add(i);
        }
        Random rnd = new Random();
        for(int i =0;i< 10;i++)
        { 
           int index= rnd.Next(1,nums.Count);
            Console.WriteLine("Removed number:"+index);
            nums.Remove(index);
        }
        foreach(int x in nums)
        {
            Console.Write(x+" ");
        }
        //--------------------------

        

        List<string> students = new List<string>();
        List<float> notes = new List<float>();
        string name;
        float note, avg , sum = 0,max,min;
         

        Console.Write("Enter number of students:");
        int NumberStudent = int.Parse(Console.ReadLine());

       
        if (NumberStudent >= 1)
        {
                
                for (int i = 0; i < NumberStudent; i++)
                {
                    Console.Write("Enter student name:");
                    name = Console.ReadLine();
                    students.Add(name);
                    Console.Write("Enter note:");
                    note = float.Parse(Console.ReadLine());

                    if(note>=0&& note <= 100)
                    {
                        notes.Add(note);
                    }
                    else
                    {
                        Console.WriteLine("İnvalid note!!");
                     i--;
                    }                      

                }
                foreach (string s in students)
                {
                    Console.Write(s + " ");
                }

                Console.WriteLine();

                foreach (float i in notes)
                {
                    Console.Write( i + " ");
                    sum += i;
                }
                max = notes[0];
                min = notes[0];
                for(int j=1;j<NumberStudent; j++)
                {
                    max = Math.Max(max, notes[j]);
                    min = Math.Min(min, notes[j]);
                }
                 
                
                avg = sum / NumberStudent;
                Console.WriteLine("\nstudents grade point average:" + avg);
                Console.WriteLine("Max note:"+max);
                Console.WriteLine("Min note:"+min);

        }
            else 
            { 
                Console.WriteLine("Try again"); 
            }

        //--------------------------

        */
        
    }
}



