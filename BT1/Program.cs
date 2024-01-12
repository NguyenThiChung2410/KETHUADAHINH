using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Saving account:");
            Account a = new SavingsAccount(100);
            a.WithDraw(80);
            a.Deposit(50);
            a.PrintBalance();
            Console.WriteLine("******************");
            Console.WriteLine("Checking account:");
            Account b = new CheckingAccount(800);
            b.WithDraw(100);
            b.Deposit(500);
            b.PrintBalance();
            Console.ReadLine();
        }
    }
}
