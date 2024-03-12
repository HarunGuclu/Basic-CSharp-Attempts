class switch_case
{
    static void Main()
    {
        double balance = 10000;

        Console.WriteLine("---MENU---\n1-Balance review\n2-Withdrawals\n3-Deposit transactions\n4-Exit");
        Console.Write("Please select your transaction:");
        string banking = Console.ReadLine();
        switch (banking)
        {
            case "1":
                Console.WriteLine("Current balance:" + balance); break;
            case "2":
                Console.Write("How much money will you withdraw:");
                double mon = double.Parse(Console.ReadLine());
                if (mon > balance)
                    Console.WriteLine("Insufficient balance.Try again...");
                else
                {
                    balance -= mon;
                    Console.WriteLine("Successful...");
                    Console.Write("Remaining balance:" + balance);
                }
                break;
            case "3":
                Console.Write("how much money do you want to deposit:");
                int dep = int.Parse(Console.ReadLine());
                balance += dep;
                Console.WriteLine("New balance:" + balance); break;
            case "4":
                Console.WriteLine("The exit is successful..."); break;
            default:
                Console.WriteLine("Incorrect entry"); break;
        }

    }
}
