using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pendergast_UnitTest1_4
{
    internal class Program
    {
        public static System.Timers.Timer aTimer;
        static void Main(string[] args)
        {
            aTimer= new System.Timers.Timer(5000);
            bool start = true;
            while (start)
            {
                Console.WriteLine("Choose your question (1-3)");
                int question = Convert.ToInt32(Console.ReadLine());
                int play = 0;
                if (question == 1)
                {
                    aTimer = new System.Timers.Timer(5000);
                    string answer = "black";
                    aTimer.Elapsed += (sender, e) =>
                    {
                        Console.WriteLine("Time's up!");
                        Console.WriteLine("The answer is: " + answer);
                        Console.WriteLine("Please press enter.");
                    };
                    Console.WriteLine("You have 5 seconds to answer the following question:");
                    aTimer.Enabled = true;
                    Console.WriteLine("What is your favorite color?");
                    string input = Console.ReadLine();
                    if (input.Equals(answer, StringComparison.CurrentCultureIgnoreCase) == true)
                    {
                        Console.WriteLine("Well Done!");
                        aTimer.Stop();
                    }
                    else if (input.Equals("", StringComparison.CurrentCultureIgnoreCase))
                    {
                        aTimer.Stop();
                    }
                    else if (input.Equals(answer, StringComparison.CurrentCultureIgnoreCase) == false)
                    {
                        Console.WriteLine("Wrong! The anwser is: " + answer);
                        aTimer.Stop();
                    }
                    while (play == 0)
                    {
                        Console.WriteLine("Play again?");
                        string retry = Console.ReadLine();
                        if (retry.Equals("no", StringComparison.CurrentCultureIgnoreCase))
                        {
                            start = false;
                            break;
                        }
                        else if (retry.Equals("yes", StringComparison.CurrentCultureIgnoreCase))
                        {
                            play++;
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Play again?");
                            retry = Console.ReadLine();
                        }
                    }
                }
                else if (question == 2)
                {
                    aTimer = new System.Timers.Timer(5000);
                    string answer = "42";
                    aTimer.Elapsed += (sender, e) =>
                    {
                        Console.WriteLine("Time's up!");
                        Console.WriteLine("The answer is: " + answer);
                        Console.WriteLine("Please press enter.");
                    };
                    Console.WriteLine("You have 5 seconds to answer the following question:");
                    aTimer.Enabled = true;
                    Console.WriteLine("What is the answer to life, the universe, and everything?");
                    string input = Console.ReadLine();
                    if (input.Equals(answer, StringComparison.CurrentCultureIgnoreCase) == true)
                    {
                        Console.WriteLine("Well Done!");
                        aTimer.Stop();
                    }
                    else if (input.Equals("", StringComparison.CurrentCultureIgnoreCase))
                    {
                        aTimer.Stop();
                    }
                    else if (input.Equals(answer, StringComparison.CurrentCultureIgnoreCase) == false)
                    {
                        Console.WriteLine("Wrong! The answer is: " + answer);
                        aTimer.Stop();
                    }
                    while (play == 0)
                    {
                        Console.WriteLine("Play again?");
                        string retry = Console.ReadLine();
                        if (retry.Equals("no", StringComparison.CurrentCultureIgnoreCase))
                        {
                            start = false;
                            break;
                        }
                        else if (retry.Equals("yes", StringComparison.CurrentCultureIgnoreCase))
                        {
                            play++;
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Play again?");
                            retry = Console.ReadLine();
                        }
                    }
                }
                else if(question == 3)
                {
                    aTimer = new System.Timers.Timer(5000);
                    string answer = "What do you mean? African or European swallow?";
                    aTimer.Elapsed += (sender, e) =>
                    {
                        Console.WriteLine("Time's up!");
                        Console.WriteLine("The answer is: " + answer);
                        Console.WriteLine("Please press enter.");
                    };
                    Console.WriteLine("You have 5 seconds to answer the following question:");
                    aTimer.Enabled = true;
                    Console.WriteLine("What is the airspeed velocity of an unladen swallow?");
                    string input = Console.ReadLine();
                    if (input.Equals(answer, StringComparison.CurrentCultureIgnoreCase) == true)
                    {
                        Console.WriteLine("Well Done!");
                        aTimer.Stop();
                    }
                    else if (input.Equals("", StringComparison.CurrentCultureIgnoreCase))
                    {
                        aTimer.Stop();
                    }
                    else if (input.Equals(answer, StringComparison.CurrentCultureIgnoreCase) == false)
                    {
                        Console.WriteLine("Wrong! The answer is: " + answer);
                        aTimer.Stop();
                    }
                    while (play == 0)
                    {
                        Console.WriteLine("Play again?");
                        string retry = Console.ReadLine();
                        if (retry.Equals("no", StringComparison.CurrentCultureIgnoreCase))
                        {
                            start = false;
                            break;
                        }
                        else if (retry.Equals("yes", StringComparison.CurrentCultureIgnoreCase))
                        {
                            play++;
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Play again?");
                            retry = Console.ReadLine();
                        }
                    }
                }
            }
        }
    }
}
