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
        protected decimal hours;
        protected decimal chargeAmt;
        // Constructor - default
        public Residential()
        {

        }
        // Constructor
        public Residential(string s, char t, decimal usage)
        {
            name = s;
            acctType = t;
            hours = usage;
        }
        // Public Attribute ChargeAmt, used primarily for savinf and reading client info from file
        public override decimal ChargeAmount
        {
            get { return chargeAmt; }
            set { chargeAmt = value; }
        }
        // Public Attribute Hours - sets usage hours for client
        public override decimal Hours
        {
            get { return hours; }
            set { hours = (value >0) ? value : 0 ; }
        }
        /// <summary>
        /// CalculateRate returns the calculated pay amount based on entity pkhours & ophours
        /// </summary>
        /// <returns>total</returns>
        public override decimal CalculateRate()
        {
            decimal total;
            total = RES_FLAT + (RES_PER_HOUR * hours);
            chargeAmt = total;
            return total;
        }
        /// <summary>
        /// ToString - provides a formatted output string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return name + "," + AccountNumber.ToString() + "," + acctType.ToString() + "," + ChargeAmount.ToString("c");
        }
        public override string ToCSV()// for writing CSV file - no formatting
        {
            return name + "," + AccountNumber.ToString() + "," + acctType.ToString() + "," + ChargeAmount.ToString();
        }
    }
}
