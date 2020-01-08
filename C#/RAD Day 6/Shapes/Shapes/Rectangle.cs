using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle: Shape
    {
        private double width, height;

        public Rectangle(string id, double w, double h) : base(id)
        {
            width = w;
            height = h;
        }
        public override double CalculateArea()
        {
            return width * height;
        }
    }
}
