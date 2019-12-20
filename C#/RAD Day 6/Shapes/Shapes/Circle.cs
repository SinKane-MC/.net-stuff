using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Circle: Shape
    {
        private double radius;

        public Circle(string id, double r): base(id)
        {
            radius = r;
        }

        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
