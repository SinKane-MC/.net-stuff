using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    public class Employee
    {
        // constants
        const decimal FULL_WEEK = 37.5m;
        const decimal OT_RATE = 1.5m;

        //private data
        private string name;
        private decimal hours;  // hours worked in a  week
        private decimal rate;   // hourly rate

        // constructor
        public Employee(string n, decimal h, decimal r)
        {
            name = n;
            // skipping validation
            hours = h;
            rate = r;
        }

        // public methods
        public virtual decimal CalculatePay() // virtual allows overriding
        {
            if (hours <= FULL_WEEK)
                return hours * rate;
            else // overtime applies
                return FULL_WEEK * rate + (hours - FULL_WEEK) * rate * OT_RATE;
        }

        protected string BasicString()
        {
            return "\n" + name + ":\n" +
                "Hours: " + hours.ToString() + " at rate/hour " +
                                        rate.ToString("c");
        }
        public override string ToString()
        {
            return BasicString() + "\n" +
                "Pay amount: " + CalculatePay().ToString("c");
        }
    }
}
