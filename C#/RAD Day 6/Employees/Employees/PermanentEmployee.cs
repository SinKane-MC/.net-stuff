using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    public class PermanentEmployee: Employee
    {
        // add private data
        private decimal rrspPct; // percent of RRSP deduction

        // derived class constructor
        public PermanentEmployee(string n, decimal h, decimal r, decimal p):
                                    base(n, h, r)// call base class constructor
        {
            rrspPct = p;
        }

        // redefined methods
        public override string ToString()
        {
            return BasicString() + "\n" +
                "RRSP %" + rrspPct + "\n" +
                "Pay amount: " + CalculatePay().ToString("c"); 
        }

        // amount of RRSP deducted
        public decimal CalculateRRSP()
        {
            return base.CalculatePay() * rrspPct / 100;
        }

        // calculate pay amount with RRSP deduction
        public override decimal CalculatePay ()
        {
            decimal basePay = base.CalculatePay(); // from the base class
            decimal rrspAmount = CalculateRRSP();
            return basePay - rrspAmount;
        }

    }
}
