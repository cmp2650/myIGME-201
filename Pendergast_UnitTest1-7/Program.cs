using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pendergast_UnitTest1_7
{
    class Program
    {
        // Calculate x^y for y > 0 using a recursive function
        static void Main(string[] args)
        {
            string sNumber;
            int nX;
            // int nY: compiling error missign a semicolon
            int nY;
            int nAnswer;

            // Console.WriteLine(This program calculates x ^ y.): compiling error missing the quotes
            Console.WriteLine("This program calculates x ^ y.");

            do
            {
                Console.Write("Enter a whole number for x: ");
                // Console.ReadLine(): compiling error sNumber is undefined and readline isnt storing sNumbers value
                sNumber = Console.ReadLine();
            } while (!int.TryParse(sNumber, out nX));

            do
            {
                Console.Write("Enter a positive whole number for y: ");
                sNumber = Console.ReadLine();
            } // while (int.TryParse(sNumber, out nX)): compiling error nY power function is unassigned since it reassigns nX and logic error requires !
            while (!int.TryParse(sNumber, out nY));

            // compute the exponent of the number using a recursive function
            nAnswer = Power(nX, nY);

            // Console.WriteLine("{nX}^{nY} = {nAnswer}"): runtime error needs index instead of variables to reference and logic error has variables part of the string
            Console.WriteLine("{0}^{1} = {2}", nX, nY, nAnswer);
        }

        // logic error should be declared outside power since it should be set to 1 to stop it from always being 0
        static int returnVal = 1;
        // int Power(int nBase, int nExponent): compiling error cant call bc it isnt static
        static int Power(int nBase, int nExponent)
        {
            // redundant
            // int nextVal = 0;

            // the base case for exponents is 0 (x^0 = 1)
            if (nExponent == 0)
            {
                // return the base case and do not recurse
                // returnVal = 0: logic error sets rerun value to 0 and always resets to 0
                // returrnVal: compiling error needs to return at the front in order to return returnVal
                return returnVal;
            }
            else
            {
                // multiply the base with all subsequent values
                // returnVal = nBase * nextVal: logic error multiplied the next value
                returnVal *= nBase;

                // compute the subsequent values using nExponent-1 to eventually reach the base case
                // nextVal = Power(nBase, nExponent + 1): runtime error should be -1 not 1 bc otherwise its infinte
                // also logic error should be last otherwise itll do nothing before calling power, dont need nextVal
                Power(nBase, nExponent - 1);
            }
            // returnVal: compiling error shoudl return to front in order to returnVal
            return returnVal;
        }
    }
}
