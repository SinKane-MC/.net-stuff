using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var acct1 = new BankAccount(500,.06m);
            var acct2 = new BankAccount(1500, .1m);
            var acct3 = new CheckingAccount(10, .06m, 1000m);
            var acct4 = new CheckingAccount(50000, .06m, 250m);
            var accts = new List<BankAccount>();
            accts.Add(acct1);
            accts.Add(acct2);
            accts.Add(acct3);
            accts.Add(acct4);

            foreach (BankAccount a in accts)
            {
                Console.WriteLine("Original Account details: " + a);
                
            }

            //Console.WriteLine(acct1);
            //Console.WriteLine(acct2);
            //Console.WriteLine(acct3);
            //Console.WriteLine(acct4);
            acct1.Withdraw(50m);
            acct2.Deposit(6000000m);
            acct2.Withdraw(100000m);
            acct3.Deposit(400m);
            acct4.Overdraft =1500m;
            acct1.Rate = .16m;
            acct4.Rate = -.07m;
            acct4.Withdraw(1000m);
            Console.WriteLine(); 
            Console.WriteLine();


            foreach (BankAccount a in accts)
            {
                Console.WriteLine("List item:" + a);
                //Console.WriteLine(a);
            }




            Console.WriteLine(" press any key to continue...");
            Console.ReadKey();
        }
    }
}
