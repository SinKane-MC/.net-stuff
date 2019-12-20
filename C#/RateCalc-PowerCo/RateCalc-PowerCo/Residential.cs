using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RateCalc_PowerCo
{

    public class Residential : Customer
    {
        // Sets the flat rate and rate per kWh for Residential customers
        private const decimal RES_FLAT = 6.00m, RES_PER_HOUR = 0.052m;
        private decimal hours;

        public Residential(string s, int a, char t, decimal usage):base(s,a,t)
        {
            hours = usage;
        }
        public override decimal CalculateRate()
        {
            decimal total;
            total = RES_FLAT + (RES_PER_HOUR * hours);
            return total;
        }
    }
}
