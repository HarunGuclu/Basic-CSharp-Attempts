using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_8._1_
{
    public class Bank_Account
    {
        private string name;
        private int balance=10000;
        private int money;
        public string name_
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int balance_
        {
            get
            {
                return balance;

            }
            set
            {
                switch (value)
                {
                    case 1:
                        Balance();
                        break;
                    case 2:
                        WithdrawMoney();
                        break;
                    case 3:
                        AddMoney();
                        break;
                    case 4:
                        Console.WriteLine("Exit successful.");
                        break;
                    default :
                        Console.WriteLine("Invalid enter.");
                        break;
                }
                balance = value;
            }
        }
        private  void Balance()
        {
            Console.WriteLine(name+"'s balance "+balance);
        }
        private void WithdrawMoney()
        {
            Console.Write("Please enter the amount to be withdrawn ");
            money=int.Parse(Console.ReadLine());
            if (money > balance)
            {
                Console.WriteLine("Insufficient balance");
            }
            else
            {
                balance-=money;
                Console.WriteLine(name+"'s available balance "+balance);
            }
        }
        private void AddMoney()
        {
            Console.Write("Please enter the amount to be added ");
            money=int.Parse(Console.ReadLine());
            balance += money;
            Console.WriteLine("Successful.Available balance "+balance);
        }
    }
}
