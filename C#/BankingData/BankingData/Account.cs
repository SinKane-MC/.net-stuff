using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingData
{
    public class Account
    {
        private static int nextNo = 100; // first Acct get No 100
        private int accountNo;
        private decimal balance;

        //read only
        public decimal Balance { get { return balance; } }


        // constructor
        public Account (decimal initBalance)
        {
            accountNo = nextNo;
            nextNo++; // prepare for next Acct
            if (initBalance >= 0)
            {
                balance = initBalance;
            }
            else // no negative balance
            {
                balance = 0;
            }
        }

        // public methods
        public void Deposit(decimal amount)
        {
            if (amount < 0)
            {
                amount = 0;
            }
            balance += amount;
        }

        public bool Withdrawl(decimal amount)
        {
            if (amount < 0)
            {
                amount = 0;
            }
            if(amount<= balance)
            {
                balance -= amount;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return accountNo.ToString() + ": " + balance.ToString("c");
        }
    }
}
