using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class Shape // abstract class - at least one method abstract
    // can't create objects of abstract class; used only to derive classes from it
    {
        private string id;

        public Shape(string id)
        {
            this.id = id;
        }
        //public virtual double CalculateArea() { return 0; }// to allow override
        public abstract double CalculateArea();// no code

        public override string ToString()
        {
            return "\n" + id + " has area " + CalculateArea().ToString("f3");
        }
    }
}
