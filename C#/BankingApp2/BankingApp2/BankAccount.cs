using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp2
{
    class BankAccount
    {
        // private Data
        protected decimal balance;
        private decimal annRate;

        // Default constructor
        public BankAccount(){          }

        // 
        public decimal Balance
        {
            get
            {
                return balance;
            }
            set
            {
                //balance = value;
            }
        }
        // public attribute
        public decimal Rate
        {
            get { return annRate; }
            set { annRate= (value > 0) ? value : .05m; }
        }

        // Const
        public BankAccount(decimal b, decimal r) 
        {
            balance = (b > 0) ? b : 0;
            Rate = r;
        }
        public bool Deposit(decimal a)
        {
            if (a > 0)
            {
                balance += a;
                return true;
            }
            else
            {
                Console.WriteLine("Non-negative value required");
                return false;
            }
        }
        public virtual bool Withdraw(decimal a)
        {
            if (a > 0 && balance > a)
            {
                balance -= a;
                return true;
            }
            else
            {
                return false;
            }
        }
        public virtual void AddMonthlyInterest()
        {
            balance += annRate * balance;
        }

        public override string ToString()
        {
            return "Account balance is " + balance.ToString("c") + " Interest Rate is "
                + annRate.ToString("f2");
        }

    }
}
