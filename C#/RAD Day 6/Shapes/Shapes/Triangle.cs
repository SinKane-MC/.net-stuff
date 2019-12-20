using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Triangle : Shape
    {
        private double bottom, height;

        public Triangle(string id, double b, double h) : base(id)
        {
            bottom = b;
            height = h;
        }
        public override double CalculateArea()
        {
            return 0.5 * bottom * height;
        }
    }
}
