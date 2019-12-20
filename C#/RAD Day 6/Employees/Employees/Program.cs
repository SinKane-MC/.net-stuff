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
            PermanentEmployee chris = new PermanentEmployee("Chris", 40, 20, 10);
            PermanentEmployee dana = new PermanentEmployee("Dana", 35, 20, 5);
            Employee emp = dana; // can assign derived class object to base type reference
                                 //PermanentEmployee permEmp = ann; // cannot assign base type object
                                 // to reference of derived type

            List<Employee> employees = new List<Employee>(); // base type list
            employees.Add(ann);
            employees.Add(bob);
            employees.Add(chris);
            employees.Add(dana);

            // display employees from the list
            foreach(Employee e in employees)
            {
                Console.WriteLine(e);// ToString method from object's class is called
                                // Polymorphism!!!
                                // same code calls various version of the method
                                // depending on the object's type
            }

            Console.WriteLine("\nCalculating Payroll:");
            decimal totalPayroll = 0;
            foreach(Employee e in employees)
            {
                decimal pay = e.CalculatePay();// method from Employee or 
                                               // PermanentEmployee called,
                                               // depending on type of e - POLYMORPHISM
                Console.WriteLine(pay.ToString("c"));
                totalPayroll += pay;
            }
            Console.WriteLine("\nTotal payroll: " + totalPayroll.ToString("c"));

            //Console.WriteLine(ann);
            //Console.WriteLine(bob);
            //Console.WriteLine(chris);
            //Console.WriteLine(dana);
            //Console.WriteLine(emp); // method called is determined by object's type

            Console.WriteLine("\n\nPress any key to finish");
            Console.ReadKey();
        }
    }
}
