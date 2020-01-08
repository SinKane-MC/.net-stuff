using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    public class Employee
    {
        // Constants
        const decimal OT_RATE = 1.5m;
        const decimal FULL_WEEK = 37.5m;

        // Private Data
        private string name;
        private decimal hours; // hours qworked in a week
        private decimal rate; // hourly rate

        // Constructor
        public Employee (string n, decimal h, decimal r)
        {
            name = n;
            hours = h;
            rate = r;
        }

        // public methods
        public virtual decimal CalculatePay()
        {
            if (hours <= FULL_WEEK)
            {
                return hours * rate;
            }
            else
            {
                return FULL_WEEK * rate + (hours - FULL_WEEK) * rate * OT_RATE;
            }
        }
            
        protected string basicString()
        {
            return "\n" + name + " : \nHours: " + hours.ToString() +
                "\nRate: " + rate.ToString("c");
        }

            public override string ToString()
        {
            return basicString() + "\nPay amount: "+ CalculatePay().ToString("c");
        }
    }

}

