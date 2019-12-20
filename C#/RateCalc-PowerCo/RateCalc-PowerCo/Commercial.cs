using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RateCalc_PowerCo
{
    public class Commercial : Customer
    {
        // Sets the flat rate and rate per kWh for Commercial customers
        const decimal COM_FLAT = 60.00m, COM_PER_HOUR = 0.045m;
        // set the base number of hours for both Commercial and Industrial clients 
        // which is used to determine if additional charges are calculated
        const int BASE_HOURS = 1000;
        private decimal hours;

        public Commercial(string s, int a, char t, decimal usage) : base(s, a, t)
        {
            hours = usage;
        }


        public override decimal CalculateRate()
        {
            decimal total;
            // If it's commercial, check if usage is over base amount
            if (hours > BASE_HOURS)
            {
                // if it's over the base amount, subtract the base and multiply
                // the remainder by the rate per hour as defined for Commercial clients
                //  and add the flat fee to the per hour charges
                total = ((hours - BASE_HOURS) * COM_PER_HOUR) + COM_FLAT;
            }
            else
            {
                // Usage was less then BASE_HOURS (1000 Hrs)
                // apply the flat rate only
                total = COM_FLAT;
            }
            return total;
        }
    }
}
