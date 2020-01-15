using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RateCalc_PowerCo
{/// <summary>
/// Base class for Customer Entities
/// </summary>
    abstract public class Customer
    {
        // protected data
        protected string name;
        protected int acctNumber;
        private static int  nextNo = 100;
        protected char acctType;
        //protected decimal chargeAmt;

        // constructtor
        public Customer() { }
        // Public Attribute Name
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        //Public Attribute Account Type
        public char AccountType
        {
            get { return acctType; }
            set { acctType = value; }
        }
        // Creates Abstract attributes that child classes can override
        public abstract decimal ChargeAmount { get; set; }
        public virtual decimal Hours { get; set; }
        // Generates the Account Number
        public int AccountNumber
        {
            get {  if (acctNumber >= 100)
                {
                    //do nothing
                }
                else
                {
                    acctNumber = nextNo;
                    nextNo++;
                }
                
                return acctNumber;
            }// set is used for setting account number based on stored client info
            set { acctNumber = value;
                nextNo = value+1;
            }
        }
        // General purpose method that each child class will override
        public virtual decimal CalculateRate()
        {
            return 0;
        }

        // Overrides the base ToString method with a formatted output
        public override string ToString()
        {
            return name + "," + AccountNumber.ToString() + "," + acctType.ToString() + "," + CalculateRate().ToString("c");
        }

        public virtual string ToCSV()// for writing CSV file - no formatting
        {
            return "0"; 
        }
    }
}
