using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp2
{
    class CheckingAccount : BankAccount
    {
        private decimal od;

        public decimal Overdraft 
        {
            get { return od; }
            set { od = (value > 0) ? value : 500m; }
        }

        public CheckingAccount(decimal b, decimal r, decimal o): base(b,r)
        {
            Overdraft = o;
        }
        public override bool Withdraw(decimal a)
        {
            if (a>0 && a <= base.Balance + od)
            {
                base.balance -= a;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void AddMonthlyInterest()
        {
            if (base.Balance > 0)
            {
                base.AddMonthlyInterest();
            }
        }
        public override string ToString()
        {
            return "Account balance is " + base.Balance.ToString("c") + " Interest Rate is "
                + base.Rate.ToString("f2") + " Available Overdraft " + od.ToString("c") ;
        }

    }
}
