using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class Shape
        // cannot create objects of an abstract class; used only to derive classes from it
    {
        //private data
        private string id;


        //public
        public Shape(string id)
        {
            this.id = id;
        }
        //public virtual double CalculateArea(){ return 0; }
        public abstract double CalculateArea();
        public override string ToString()
        {
            return id + " has an area of " + CalculateArea().ToString("f3");
        }
    }
}
