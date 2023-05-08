using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pendergast_FinalExam_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] adjacencyMatrix = {
                {0, 5, 1, 0, 0, 0, 0, 0}, // 0 = red
                {0, 0, 0, 0, 1, 0, 0, 0}, // 1 = gray
                {0, 0, 0, 1, 0, 0, 0, 0}, // 2 = dark blue
                {0, 0, 1, 0, 0, 0, 0, 0}, // 3 = light blue
                {0, 0, 0, 0, 0, 0, 1, 0}, // 4 = orange
                {0, 0, 0, 0, 0, 0, 1, 6}, // 5 = yellow
                {0, 0, 0, 0, 0, 1, 0, 0}, // 6 = purple
                {0, 0, 0, 0, 0, 1, 0, 0}, // 7 = green
            };

            // converts array into list
            List<(int, int)> edgeList = new List<(int, int)>();

            for (int i = 0; i < adjacencyMatrix.GetLength(0); i++)
            {
                for (int j = i; j < adjacencyMatrix.GetLength(1); j++)
                {
                    if (adjacencyMatrix[i, j] != 0)
                    {
                        edgeList.Add((i + 1, j + 1));
                    }
                }
            }
        }
    }
}
