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
        // private data
        protected string name;
        protected int acctNumber;
        private static int  nextNo = 100;
        protected char acctType;
        //protected decimal chargeAmt;

        // constructtor
        public Customer() { }
        
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public char AccountType
        {
            get { return acctType; }
            set { acctType = value; }
        }
        public abstract decimal ChargeAmount { get; set; }
       
        public virtual decimal Hours { get; set; }
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
            }
            set { acctNumber = value;
                nextNo = value+1;
            }
        }
        public virtual decimal CalculateRate()
        {
            return 0;
        }


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
