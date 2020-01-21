using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // define data source
            double[] sample = { 1.5, -5, -3.4, 9, 15.2, -2.1 };


            // define LINQ query
            var sampleNumbers = from num in sample
                                where num > 0
                                orderby num descending
                                select num;

            // Execute
            foreach (var n in sampleNumbers)
                Console.Write(n + "\t");
            Console.WriteLine();


            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
