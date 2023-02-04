using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Pendergast_PE07
{
    // Class Program
    // Author: Chloe Pendergast
    // Purpose: Mad Libs
    // Restrictions: None
    static internal class Program
    {
        // Method: Main
        // Purpose: Asks user if they want to play a mad libs game, and loads in the text file, goes through a loop
        // Restrictions: None
        static void Main(string[] args)
        {
            // asks user if they want to play via loop
            int x = 0;
            while (x < 1)
            {
                Console.WriteLine("Wanna play a game? Yes or no.");
                string response = Console.ReadLine();
                response = response.ToLower();
                if (response == "no")
                {
                    // if no ends loop and says goodbye
                    Console.WriteLine("See ya later");
                    x++;
                }
                else if (response == "yes")
                {
                    // play the game 
                    // loads text file
                    StreamReader input = new StreamReader("C:\\Users\\chloe\\Documents\\201\\MadLibsTemplate.txt");
                    // story variable
                    int count = File.ReadAllLines("C:\\Users\\chloe\\Documents\\201\\MadLibsTemplate.txt").Length;
                    Console.WriteLine("Select a story 1-" + count);
                    int mlNum = Convert.ToInt32(Console.ReadLine());
                    string mlLine;
                    // story list
                    List<string> lines = new List<string>();
                    string line;
                    while ((line = input.ReadLine()) != null)
                    {
                        lines.Add(line);
                    }
                    // splits selcted story into words
                    string[] newLine = lines[mlNum].Split(' ');
                    // loops through the story until done
                    for (int i = 0; i < newLine.Length; i++)
                    {
                        // makes array of characters for every word
                        char[] newWord = newLine[i].ToCharArray();
                        // tests if { is first character or an input
                        if (newWord[0] == '{')
                        {
                            // asks for input and replaces blank
                            Console.WriteLine("Please enter a/an: " + newLine[i].Trim('{', '}', ',').Replace('_', ' '));
                            string inputWord = Console.ReadLine();
                            newLine[i] = inputWord;
                        }
                        // tests for \n
                        else if (newLine[i].Equals("\\n"))
                        {
                            // inputs new line into place
                            newLine[i] = "\n";
                        }
                    }

                    // makes final string into the output of the filled out mad lib
                    mlLine = string.Join(" ", newLine.ToArray());
                    // prints result and ends loop
                    Console.WriteLine(mlLine);
                    x++;
                }
                else
                {
                    // if the response is invalid, asks user to to retry and repears the loop
                    Console.WriteLine("Invalid input, enter yes or no");
                }
            }
        }
    }
}