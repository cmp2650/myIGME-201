using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pendergast_PE06
{
    // Class: Program
    // Author: Chloe Pendergast
    // Purpose: Guess the number
    // Restriction: None

    internal class Program
    {
        // Method: Main
        // Purpose: loop to increased valid guesses and stops when out of guesses or if number is correctly guessed
        // Restrictions: None
        static void Main(string[] args)
        {
            Random rand = new Random();

            // makes a raomdom number bewteen 0 and 101 exclusive
            int randomNumber = rand.Next(0, 101);

            // used to check if the number actually would appear and be right
            // Console.WriteLine(randomNumber.ToString());
            // while loop counter
            int i = 1;
            while(i < 9)
            {
                // asks user for guess and converts it to a variable
                Console.WriteLine("Turn " + i + ": Enter your guess: ");
                int guess = Convert.ToInt32(Console.ReadLine());
                // if statement to check if guess is valid or the correct number
                if(guess == randomNumber)
                {
                    Console.WriteLine("Congratulations! You guessed correctly.");
                    break;
                }
                else if (guess < 0 || guess > 100)
                {
                    Console.WriteLine("Invalid guess, try again.");
                }
                else if (guess < randomNumber)
                {
                    Console.WriteLine("Too low.");
                    i++;
                }
                else if (guess > randomNumber)
                {
                    Console.WriteLine("Too high.");
                    i++;
                }
            }

        // if statement for if you run out of guesses
        if (i == 9)
            {
                Console.WriteLine("You failed to guess in 8 tries.");
            }
        }
    }
}
