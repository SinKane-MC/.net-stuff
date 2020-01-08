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
            List<Product> products = new List<Product>(); // empty list

            Product p1; // defines reference variable
            p1 = new Product(); // create an object - 
                                //implicit call to default constructor
            p1.Name = "gadget";
            p1.Price = 9.99m;// use set part of property Price
            //Console.WriteLine("The price is " + p1.Price.ToString("c")); // uses get part of property Price
            p1.Qty = 15;
            
           //Console.WriteLine(p1);// implicit call to ToString() method

            Product p2 = new Product("widget", 7.99m, 25); // implicit call to
                                                            // constructor with params
            //Console.WriteLine(p2);

            Product p3 = new Product("gizmo", 4.99m, 10);
            //Console.WriteLine(p3);

            // add products to the list
            products.Add(p1);
            products.Add(p2);
            products.Add(p3);

            Console.WriteLine("\nProducts in the list:");
            foreach (Product p in products) // for each product in the list
                Console.WriteLine(p);       // implicitly calls ToString from p

            Console.WriteLine("\nINVENTORY:");
            decimal totalInventory = 0;
            decimal next;
            foreach(Product p in products)
            {
                next = p.InventoryValue();
                Console.WriteLine(p.Name + ": " + next.ToString("c"));
                totalInventory += next;
            }
            Console.WriteLine("Total inventory: " + totalInventory.ToString("c"));

            Console.WriteLine("\nPress any key to finish");
            Console.ReadKey();
        }
    }
}
