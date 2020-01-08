using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RateCalc_PowerCo
{
    public class Industrial :Customer
    {
        // set the base number of hours for Industrial clients 
        // which is used to determine if additional charges are calculated
        const int BASE_HOURS = 1000;
        // Sets the flat rate and per kWh rates for both Peak and Off Peak usage for
        // Industrial clients
        const decimal IND_PK_FLAT = 76.00m, IND_PK_PER_HOUR = 0.065m, IND_OP_FLAT = 40.00m, IND_OP_PER_HOUR = 0.028m;
        protected decimal chargeAmt;

        public Industrial()
        {

        }

        protected decimal pkHours, opHours;
        public Industrial(string s, char t, decimal pkUsage, decimal opUsage)
        {
            name = s;
            acctType = t;
            pkHours = pkUsage;
            opHours = opUsage;
        }

       
        public override decimal CalculateRate()
        {
            decimal total;
            // Set temporary varibles to perfrom some math for Peak and Off Peak charges
            decimal indAmountPK, indAmountOP;
            if (pkHours > BASE_HOURS)
            {
                // if the Peak usage is over the base amount, subtract
                // the base hours and multiply the remainder by the per hour rate
                // and add the flat rate fee
                indAmountPK = ((pkHours - BASE_HOURS) * IND_PK_PER_HOUR) + IND_PK_FLAT;
            }
            else
            {
                // Usage was less then BASE_HOURS (1000 Hrs)
                // apply the flat rate only
                indAmountPK = IND_PK_FLAT;
            }

            if (opHours > BASE_HOURS)
            {
                // if the Off Peak usage is over the base amount, subtract
                // the base hours and multiply the remainder by the Off Peak per hour
                // rate and add the Off Peak flat rate fee
                indAmountOP = ((opHours - BASE_HOURS) * IND_OP_PER_HOUR) + IND_OP_FLAT;
            }
            else
            {
                // Usage was less then BASE_HOURS (1000 Hrs)
                // apply the flat rate only
                indAmountOP = IND_OP_FLAT;
            }
            // add the Peak and Off Peak amounts 
            total = indAmountPK + indAmountOP;
            chargeAmt = total;
            return total;
        }

        public override decimal ChargeAmount
        {
            get { return chargeAmt; }
            set { chargeAmt = value; }
        }

        public decimal PeakHours { get { return pkHours; } set {  pkHours = (value > 0) ? value : 0;  } }
        public decimal OffPeakHours { get { return opHours; } set { opHours = (value > 0) ? value : 0; } }
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
