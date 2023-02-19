using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pendergast_UnitTest1_5
{
    internal class Program
    {
        static string sName = "Chloe";
        static double dSalary = 30000;
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name.");
            string yourName = Console.ReadLine();
            GiveRaise(yourName, ref dSalary);
        }
        static bool GiveRaise(string name, ref double salary)
        {
            if (name.Equals(sName, StringComparison.CurrentCultureIgnoreCase))
            {
                dSalary = salary + 19999.99;
                Console.WriteLine("Well done " + name + "!");
                Console.WriteLine("Your salary has been increased to: " + dSalary);
                return true;
            }
            else
            {
                Console.WriteLine("We regret to inform you, " + name + ", you are staying poor.");
                return false;
            }
        }
    }
}
