using Class_6._1_;
using System.Diagnostics.Metrics;
using System.Diagnostics;

namespace Class_6._1_
{

    class Program
    {

        static void Main(string[] args)
        {
            studentinf studentinf1 = new studentinf();
            studentavg studentavg1 = new studentavg();
            studentschool studentschool1 = new studentschool();
            Console.WriteLine("-----MENU----    ");
            Console.WriteLine("1-Student Information\n2-Student Average\n3-Student School\n4-Exit");



            int choose;
            choose = int.Parse(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    {
                        studentinf1.studentno = "221118001";
                        studentinf1.studentname = "Harun";
                        studentinf1.studentsurname = "Guclu";
                        Console.WriteLine(studentinf1.studentno);
                        Console.WriteLine(studentinf1.studentname);
                        Console.WriteLine(studentinf1.studentsurname);
                        break;
                    }

                case 2:
                    {
                        Console.Write("please enter the student's visa exam score:");
                        studentavg1.visaexam = int.Parse(Console.ReadLine());
                        Console.Write("please enter the student's final exam score:");
                        studentavg1.finalexam = int.Parse(Console.ReadLine());

                        studentavg1.average = studentavg1.visaexam * 0.4 + studentavg1.finalexam * 0.6;
                        Console.WriteLine("Average:" + studentavg1.average);
                        if(studentavg1.average >= 90&& studentavg1.average<=100)
                            Console.WriteLine("letter grade:AA");
                        else if (studentavg1.average<90&& studentavg1.average>=85)
                        {
                            Console.WriteLine("letter grade:BA");
                        }
                        else if (studentavg1.average>=80&& studentavg1.average<85)
                        {
                            Console.WriteLine("letter grade:BB");
                        }
                        else if (studentavg1.average>=70&& studentavg1.average<80)
                        {
                            Console.WriteLine("letter grade:CB");
                        }
                        else if (studentavg1.average>=60&& studentavg1.average<70)
                        {
                            Console.WriteLine("letter grade:CC");
                        }
                        else if (studentavg1.average>=50&& studentavg1.average<60)
                        {
                            Console.WriteLine("letter grade:DC");
                        }
                        else if (studentavg1.average>=45&& studentavg1.average<50)
                        {
                            Console.WriteLine("letter grade:DD");
                        }
                        else
                        {
                            Console.WriteLine(" failed the class...Letter grade:FF");
                        }
                        break;
                    }

                case 3:
                    {
                        Console.WriteLine(studentschool1.uni);
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Exit successful");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("incorrect entry");
                        break;

                    }

            }


        }

     
    }
}
