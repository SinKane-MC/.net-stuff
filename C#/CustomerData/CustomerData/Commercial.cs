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
        protected decimal hours;
        protected decimal chargeAmt;

        public Commercial()
        {

        }

        public Commercial(string s, char t, decimal usage)
        {
            name = s;
            acctType = t;
            hours = usage;
        }
        public override decimal Hours
        {
            get { return hours; }
            set { hours = value; }
        }

        public override  decimal ChargeAmount
        {
            get { return chargeAmt; }
            set { chargeAmt = value; }
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
            chargeAmt = total;
            return total;
        }

        public override string ToString()
        {
            return name + "," + AccountNumber.ToString() + "," + acctType.ToString() + "," + chargeAmt.ToString("c");
        }
        public override string ToCSV()// for writing CSV file - no formatting
        {
            return name + "," + AccountNumber.ToString() + "," + acctType.ToString() + "," + chargeAmt.ToString();
        }
    }
}
