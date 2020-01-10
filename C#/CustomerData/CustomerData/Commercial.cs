using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Commercial Client class
/// used to collect date and perform calculations and functions on the data
/// </summary>
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

        // default Constructor
        public Commercial()
        {

        }
        /// <summary>
        /// Class constructor, assign values to local variables
        /// </summary>
        /// <param name="s">Client name</param>
        /// <param name="t">Client type</param>
        /// <param name="usage">usage hours</param>
        public Commercial(string s, char t, decimal usage)
        {
            name = s;
            acctType = t;
            hours = usage;
        }
        /// <summary>
        /// Public Attribute Hours
        /// sets the usage hours for the entity
        /// </summary>
        public override decimal Hours
        {
            get { return hours; }
            // check the value, if null or negative then set it to zero
            set { hours = (value > 0) ? value : 0; } 
        }
        /// <summary>
        /// Public Attribute ChargeAmount
        /// used to set the chargeAmt of an entity during the loading of data from disk
        /// </summary>
        public override  decimal ChargeAmount
        {
            get { return chargeAmt; }
            // check the value, if null or negative then set it to zero
            set { chargeAmt = (value > 0) ? value : 0; }
        }
        /// <summary>
        /// Public method CalculateRate
        /// used to determine the payout amount for the client
        /// based on the usage hours
        /// </summary>
        /// <returns>Payout amount (total)</returns>
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
            chargeAmt = total; // set entity attribute
            return total; // rteturn the value
        }
        /// <summary>
        /// Override default method ToString
        /// </summary>
        /// <returns>formatted string</returns>
        public override string ToString()
        {
            return name + "," + AccountNumber.ToString() + "," + acctType.ToString() + "," + chargeAmt.ToString("c");
        }
        /// <summary>
        /// Formats output for writing to a CSV file, no additional formatting
        /// </summary>
        /// <returns></returns>
        public override string ToCSV()
        {
            return name + "," + AccountNumber.ToString() + "," + acctType.ToString() + "," + chargeAmt.ToString();
        }
    }
}
