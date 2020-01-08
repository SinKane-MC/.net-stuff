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

            //Shape s = new Shape("Shape1"); // unable to create objects of abstract class
            Circle c = new Circle("Circle1", 5);
            Rectangle r = new Rectangle("Rectangle1",5, 10);
            Triangle t = new Triangle("Triangle1",5, 10);

            //Console.WriteLine(s);
            Console.WriteLine(c);
            Console.WriteLine(r);
            Console.WriteLine(t);

            Console.WriteLine("\nPress any ket to contiue...");
            Console.ReadKey();

        }
    }
}
