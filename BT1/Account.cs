using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1
{
    class Account
    {
        private double _balance;

        public double Balance
        {
            set { this._balance = value; }
            get { return _balance; }
        }
        public virtual bool WithDraw(double amount)
        {
            return false;
        }
        public virtual bool Deposit(double amount)
        {
            return false;
        }
        public virtual void PrintBalance()
        {
            Console.WriteLine("Balance:{0}", _balance);
        }
    }
}
