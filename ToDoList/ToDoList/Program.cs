class Program
{
    static void Main(string[] args)
    {
        List<string> Tasks = new List<string>();
        int choose;
        string task;
        while(true) 
        {
            Console.Clear();
            Console.WriteLine("---TO-DO LIST---");
            Console.WriteLine("1->Add Task\n2->Remove Task\n3->Mark Task\n4->Exit");
            Console.Write("Enter your choose:");
            
            choose=int.Parse(Console.ReadLine());
            if (choose == 4) { Console.WriteLine("Exit successfull.."); break; }
            switch (choose)
            {
                case 1:
                    do
                    {


                        Console.Write("Please add task:");
                        task = Console.ReadLine();
                        Tasks.Add(task);
                        Console.WriteLine("The task was successfully added. Would you like to add another?(y-n)");
                        task = Console.ReadLine();
                        while (task != "y" && task != "n")
                        {
                            Console.WriteLine("Wrong choice.Would you like to add another?(y-n)");
                            task = Console.ReadLine();
                        }
                    } while (task=="y");
                   break;
                case 2:
                    try
                    {
                        do
                        {
                            for (int i = 0; i < Tasks.Count; i++)
                            {
                                Console.WriteLine((i + 1) + "." + Tasks[i]);
                            }
                            Console.Write("Enter the number of the task to be removed:");
                            int task_ = int.Parse(Console.ReadLine());
                            Tasks.RemoveAt(task_ - 1);
                            Console.WriteLine("The task was successfully removed. Would you like to remove another?(y-n)");
                            task = Console.ReadLine();
                            while (task == "y" && task == "n")
                            {
                                Console.WriteLine("Wrong choice.Would you like to remove another?(y-n)");
                            }
                        } while (task == "y");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error."+ex);
                    }
                    break;
                    
                    
                  

                case 3:
                    try
                    {
                        do
                        {
                            for (int i = 0; i < Tasks.Count; i++)
                            {
                                Console.WriteLine((i + 1) + "." + Tasks[i]);
                            }
                            Console.Write("Select the task to mark:");
                            int task_ = int.Parse(Console.ReadLine());
                            Console.WriteLine("Task marked.Would you like to mark another task?(y-n)");
                            task = Console.ReadLine();
                            while (task == "y" && task == "n")
                            {
                                Console.WriteLine("Wrong choice.Would you like to mark another task?(y-n)");
                            }
                        } while (task == "y");
                        
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine("Error.."+ex);
                    }
                    break;



                default:
                    Console.WriteLine("Wrong choice.Try again.");
                    break;
            }

        } 
    }
}