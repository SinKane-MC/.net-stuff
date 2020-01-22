using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<double> doubles = new List<double>{1.5, 0, -6.3, 2.7, 8.9, -4.2};
            foreach(double num in doubles)
            {
                Console.WriteLine("\n" + num);
            }
            


            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}
