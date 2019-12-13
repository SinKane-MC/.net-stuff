using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClass
{
    class Program
    {
        static void Main(string[] args)
        {

            //Product p1 = new Product();
            //p1.Name = "Widget";
            //p1.Price = 9.99m;
            //p1.Qty = 33;

            //Console.WriteLine(p1); // implicitly calls ToString() method

            //Product p2 = new Product("Gadget", 7.78m, 12);
            //Console.WriteLine(p2);
            Employee e1 = new Employee();
            e1.Name = "Kirk Hammet";
            e1.Salary = 399999m;

            Console.WriteLine(e1);

            Employee e2 = new Employee("John Wick", -120000m);
            Console.WriteLine(e2);           

            Console.Write("\nPress any key to continue...");
            Console.ReadKey();

        }
    }
}
