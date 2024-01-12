using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1
{
    class SavingsAccount:Account
    {
        private double _interesRate = 0.8;
        public SavingsAccount() : base()
        {

        }
        public SavingsAccount(double balance) : base()
        {
            this.Balance = balance;
        }
        public double InteresRate
        {
            set { this._interesRate = value; }
            get { return _interesRate; }
        }
        public override bool WithDraw(double amount)
        {
            if (amount > 0 && Balance >= amount)
            {
                Balance = Balance - (amount + amount * InteresRate);
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
                Balance = Balance + (amount + amount * InteresRate);
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
            Console.WriteLine("Saving account balance:{0}", Balance);
        }
    }
}
