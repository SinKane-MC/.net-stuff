using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClass
{
    public class Employee
    {
        // private data
        string name;
        decimal salary;
               
        //public properties
        public string Name
        {
            get { return name; }
            set { name = value; } // assign value that is passed in when property is used     
        }

        public decimal Salary
        {
            get { return salary; }
            set { salary = (value < 0) ? -value : value; } // if provided value is less then zero, use the absolute value  
        }

        // Constructors
        // if you don't provide a constructor, the complier supplies a default constructor with no parameters
        public Employee() { } // default contructor

        public Employee(string n, decimal s)
        {
            Name = n; // use the public properties so that data validation still runs
            Salary = s; // Name instead of name, Salary instead of salary
        }

        // Public operations
        public override string ToString()
        {
            return name + ": " + salary.ToString("c");
        }





    }
}
