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

            // question 8
            int start = 1;
            double[,,] calculate;
            for (double x = -1; x <= 1; x += 0.1)
            {
                for (double y = 1; y <= 4; y += 0.1)
                {
                    double z = 4 * (Math.Pow(y, 3)) + 2 * (Math.Pow(x, 2)) - (8 * x) + 7;
                    calculate[(int)x, (int)y, (int)z] = start++;
                }
            }
            for (double a = -1; a <= 1; a += 0.1)
            {
                for (double b = 1; b <= 4; b += 0.1)
                {
                    for (double c = 1; c <= 651; c++)
                    {
                        double roundX = round(Convert.ToString(calculate[(int)a, (int)b, (int)c]), 1);
                    }
                }
            }
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
