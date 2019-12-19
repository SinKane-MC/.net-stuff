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
            List<Product> products = new List<Product>();

            Product p1 = new Product();
            p1.Name = "Widget";
            p1.Price = 9.99m;
            p1.Qty = 33;

            Product p2 = new Product("Gadget", 7.78m, 12);
            Product p3 = new Product("Gizmo", 4.49m, 10);
            //Console.WriteLine(p1); // implicitly calls ToString() method
            //Console.WriteLine(p2);
            //Console.WriteLine(p3);

            //add products to the list
            products.Add(p1);
            products.Add(p2);
            products.Add(p3);

            // Producst in the list
            Console.WriteLine("\nProducts in the list:");
            foreach (Product p in products)
                Console.WriteLine(p);
            Console.WriteLine("\n");
            Console.WriteLine("\nInventory:");
            decimal totalInventory = 0;
            decimal next;
                foreach(Product p in products)
            {
                next = p.InventoryValue();
                Console.WriteLine(p.Name + ": " + next.ToString("c"));
                totalInventory += next;
            }
                
                
            //    = p1.InventoryValue();
            //Console.WriteLine(p1.Name + ": " + next.ToString("c"));
            //totalInventory += next;
            //next = p2.InventoryValue();
            //Console.WriteLine(p2.Name + ": " + next.ToString("c"));
            //totalInventory += next;
            //next = p3.InventoryValue();
            //Console.WriteLine(p3.Name + ": " + next.ToString("c"));
            //totalInventory += next;

            Console.WriteLine("Total inventory: " + totalInventory.ToString("c"));
            //Employee e1 = new Employee();
            //e1.Name = "Kirk Hammet";
            //e1.Salary = 399999m;

            //Console.WriteLine(e1);

            //Employee e2 = new Employee("John Wick", 120000m);
            //Console.WriteLine(e2);           

            Console.Write("\nPress any key to continue...");
            Console.ReadKey();

        }
    }
}
