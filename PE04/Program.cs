using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int var1, var2;
            Console.WriteLine("Enter Two Numbers ");
            var1 = Convert.ToInt32(Console.ReadLine());
            var2 = Convert.ToInt32(Console.ReadLine());
            if (var1 >= 10 && var2 >= 10)
            {
                Console.WriteLine("Invalid Input ");
            }
            else if (var1 <= 10 && var2 <=10) {
                Console.WriteLine("Invalid Input ");
            }
            else if (var1> 1)
            {
                Console.WriteLine("Valid Input");
            }
            else if (var2> 1)
            {
                Console.WriteLine("Valid Input");
            }
            Console.ReadLine();
        }
    }
}
