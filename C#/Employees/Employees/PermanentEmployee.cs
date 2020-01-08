using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    public class PermanentEmployee : Employee
    {
        // inherits all Employye class items

        //add private data
        private decimal rrspPct;

        // Constructor
        public PermanentEmployee(string n, decimal h, decimal r, decimal p):
            base(n,h,r)
        {
            rrspPct = p;
            
        }

        public override string ToString()
        {
            return basicString() + "\nRRSP %: " + rrspPct +
                "\nPay amount: " + CalculatePay().ToString("c");
        }

        public override decimal CalculatePay()
        {
            decimal basePay = base.CalculatePay();
            decimal rrspAmt = CalculateRRSP();

            return basePay- rrspAmt;
        }

        public decimal CalculateRRSP()
        {
            return base.CalculatePay() * rrspPct / 100;
        }
    }
}
