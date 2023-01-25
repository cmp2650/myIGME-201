using System;

namespace SquashTheBugs
{
    // Class Program
    // Author: Chloe Pendergast
    // Purpose: Bug squashing exercise
    // Restrictions: None
    class Program
    {
        // Method: Main
        // Purpose: Loop through the numbers 1 through 10 
        //          Output N/(N-1) for all 10 numbers
        //          and list all numbers processed
        // Restrictions: None
        static void Main(string[] args)
        {
            // declare int counter
            // syntax - missing ;
            // runtime - outputs = 1, instead of actual number
            // int i = 0
            float i = 0;

            // declare string to hold all numbers
            // logic - had to be moved out of the scope
            string allNumbers = null;

            // loop through the numbers 1 through 10
            // runtime/logic - only goes to 9 but not 10
            // for (i = 1; i < 10; ++i)
            for (i = 1; i < 11; ++i)
            {

                // output explanation of calculation
                // syntax - missing parenthesis
                // Console.Write(i + "/" + i - 1 + " = ");
                Console.Write(i + "/" + (i - 1) + " = ");

                // output the calculation based on the numbers
                // runtime - at 1 it divides by 0
                // Console.WriteLine(i / (i - 1));
                if (i == 1) {
                    Console.WriteLine("Can't Divide By 0");
                
                } else
                {
                    Console.WriteLine(i / (i - 1));
                }

                // concatenate each number to allNumbers
                allNumbers += i + " ";

                // increment the counter
                // logic - it's already incrementing in the for loop
                // i = i + 1;
            }

            // output all numbers which have been processed
            // syntax - missing concatenation
            // Console.WriteLine("These numbers have been processed: " allNumbers);
            Console.WriteLine("These numbers have been processed: " + allNumbers);
        }
    }
}