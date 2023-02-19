using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pendergast_UnitTest1_5
{
    internal class Program
    {
        struct employee
        {
            public string sName;
            public double dSalary;
            public string name;
        }
        static void Main(string[] args)
        {
           employee employee = new employee();
            employee.sName = "Chloe";
            employee.dSalary = 30000;
            Console.WriteLine("Please enter your name.");
            employee.name = Console.ReadLine();
            GiveRaise(employee);
        }
        static bool GiveRaise(employee employee)
        {
            if (string.Equals(employee.name, employee.sName, StringComparison.CurrentCultureIgnoreCase))
            {
                employee.dSalary += 19999.99;
                Console.WriteLine("Well done " + employee.name + "!");
                Console.WriteLine("Your salary has been increased to: " + employee.dSalary);
                return true;
            }
            else
            {
                Console.WriteLine("We regret to inform you, " + employee.name + ", you are staying poor.");
                return false;
            }
        }
    }
}
