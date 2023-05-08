using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pendergast_FinalExam_4
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

            bool[] visited = new bool[adjacencyMatrix.GetLength(0)];

            DFS(0); // start from red


            void DFS(int vertex)
            {
                visited[vertex] = true;
                Console.WriteLine(GetColor(vertex));

                for (int i = 0; i < adjacencyMatrix.GetLength(0); i++)
                {
                    if (adjacencyMatrix[vertex, i] != 0 && !visited[i])
                    {
                        DFS(i);
                    }
                }
            }

            string GetColor(int vertex)
            {
                switch (vertex)
                {
                    case 0:
                        return "red";
                    case 1:
                        return "gray";
                    case 2:
                        return "Dark Blue";
                    case 3:
                        return "Light Blue";
                    case 4:
                        return "Orange";
                    case 5:
                        return "Yellow";
                    case 6:
                        return "Purple";
                    case 7:
                        return "Green";
                    default:
                        return "";
                }
            }
        }



    }
}
