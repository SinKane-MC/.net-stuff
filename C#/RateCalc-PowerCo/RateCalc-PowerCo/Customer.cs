using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RateCalc_PowerCo
{
    abstract public class Customer
    {
        // private data
        private string name;
        private int acctNumber;
        private char acctType;

        // constructtor
        public Customer(string s, int n, char t)
        {
            name = s;
            acctNumber = n;
            acctType = t;

        }

        public abstract decimal CalculateRate();
          
        
        public override string ToString()
        {
            return base.ToString();
        }

    }
}
