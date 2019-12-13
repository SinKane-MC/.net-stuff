using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClass
{
    public class Product
    {
        // Private data
        private string name;
        private decimal price;
        private int qty;

        // Public properties
        public string Name
        {
            get { return name; }
            set { name = value; } // assign value that is passed in when property is used             
        }

        public decimal Price
        {
            get { return price; }
            set { price = (value < 0) ? -value : value; } // if provided value is less then zero, use the absolute value
        }
        public int Qty
        {
            get { return qty; }
            set { qty = (value < 0) ? -value : value; } // if provided value is less then zero, use the absolute value
        }

        // Constructors
        // if you don't provide a constructor, the complier supplies a default constructor with no parameters
        public Product() { } // default contructor
        
        public Product(string n, decimal p, int q)
        {
            Name = n;
            Price = p; // use the public properties so that data validation still runs
            Qty = q; // Price instead of price, Qty instead of qty
        }

        // Public operations
        public override string ToString()
        {
            return name + ": " + price.ToString("c") + ", "  + qty.ToString();
        }

    }
}
