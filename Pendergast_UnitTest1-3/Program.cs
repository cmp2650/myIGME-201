using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pendergast_UnitTest1_3
{
    internal class Program
    {
        delegate double Round(string number, int length);
        static void Main(string[] args)
        {
            Round round = new Round(RoundNum);
            Console.WriteLine("Enter a number to round:");
            string doubleString = Console.ReadLine();
            Console.WriteLine("Enter the amount of decimal places:");
            int stringLength = Convert.ToInt32(Console.ReadLine());
            double end = round(doubleString, stringLength);
            Console.WriteLine();
            Console.WriteLine(end);
        }
        public static double RoundNum(string number, int length)
        {
            char[] num = number.ToCharArray();
            char[] endString = new char[num.Length];
            int moreLength = num.Length;

            for (int i = 0; i < moreLength; i++)
            {
                if (number.Contains("."))
                {
                    if (i == length)
                    {
                        if (Convert.ToInt32(num[i + 1]) >= 53)
                        {
                            num[i] = Convert.ToChar(Convert.ToInt32(num[i]) + 1);
                            endString[i] = num[i];
                            break;
                        }
                        else
                        {
                            endString[i] = num[i];
                            break;
                        }
                    }
                }
                else
                {
                    if (i == length - 1)
                    {
                        if (Convert.ToInt32(num[i +1]) >= 53)
                        {
                            num[i] = Convert.ToChar(Convert.ToInt32(num[i]) + 1);
                            endString[i] = num[i]; 
                            break;
                        }
                        else
                        {
                            endString[i] = num[i];
                            break;
                        }
                    }
                }
                endString[i] = num[i];
            }
            double lastRound = Convert.ToDouble(string.Join("", endString));
            return lastRound;
        }
    }
}
