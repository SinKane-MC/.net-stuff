using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee ann = new Employee("Ann", 40, 20);
            Employee bob = new Employee("Bob", 35, 20);
            PermanentEmployee kris = new PermanentEmployee("Kris", 40, 20, 10);
            PermanentEmployee dana = new PermanentEmployee("Dana", 35, 20, 5);


            Console.WriteLine(ann);
            Console.WriteLine("\n" + bob);
            Console.WriteLine("\n" + kris);
            Console.WriteLine("\n" + dana);

            Console.WriteLine("\n\nPress any key to continue...");
            Console.ReadKey();

        }
    }
}
