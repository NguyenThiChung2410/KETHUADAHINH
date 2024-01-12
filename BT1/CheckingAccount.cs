using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1
{
    class CheckingAccount:Account
    {
        public CheckingAccount() : base() { }
        public CheckingAccount(double Balance) : base() { }
        public override bool WithDraw(double amount)
        {
            if (amount > 0 && Balance >= 0)
            {
                Balance = Balance - amount;
                Console.WriteLine("Giao dich thanh cong");
                Console.WriteLine("So tien da rut la:{0}", Balance);
                return true;

            }
            else
                Console.WriteLine("Giao dich that bai");
            return false;

        }
        public override bool Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance = Balance + amount;
                Console.WriteLine("Giao dich thanh cong");
                Console.WriteLine("So tien da them la:{0}", Balance);
                return true;

            }
            else
                Console.WriteLine("Giao dich that bai");
            return false;

        }
        public override void PrintBalance()
        {
            Console.WriteLine("Checking account balance:{0}", Balance);
        }
    }
}
