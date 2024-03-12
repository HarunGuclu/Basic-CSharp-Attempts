using Encapsulation_8._1_;

class Program
{
    static void Main(string[] args)
    {
        Bank_Account bank_account = new Bank_Account();
        bank_account.name_ = "Metin";
        
        Console.WriteLine("-----Menu-----");
        Console.WriteLine("1-Your balance\n2-Withdraw money\n3-Add money\n4-Exit");
        int prefer=int.Parse(Console.ReadLine());
        switch (prefer)
        {
            case 1:
                bank_account.balance_ = 1;
               
                break;
            case 2:
                bank_account.balance_=2;
                break;
            case 3:
                bank_account.balance_=3;
                break;
            default:
                bank_account.balance_ = 4;
                break;
        }

    }
}