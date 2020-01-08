using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            //Shape s1 = new Shape("Shape 1");// cannot create object of abstract class
            //shapes.Add(s1);
            Circle c1 = new Circle("Circle 1", 2);
            shapes.Add(c1);
            Rectangle r1 = new Rectangle("Rectangle 1", 2.5, 3);
            shapes.Add(r1);
            Triangle t1 = new Triangle("Triangle 1", 2.5, 3);
            shapes.Add(t1);

            //display shapes from the list
            foreach (Shape s in shapes)
                Console.WriteLine(s);

            Console.WriteLine("\nPress any key to finish");
            Console.ReadKey();
        }
    }
}
