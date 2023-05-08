using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pendergast_FinalExam_5
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

            Dictionary<int, int> distances = new Dictionary<int, int>();
            Dictionary<int, int> previous = new Dictionary<int, int>();
            List<int> unvisited = new List<int>();

            // distance set to infinity except starting value
            for (int i = 0; i < adjacencyMatrix.GetLength(0); i++)
            {
                distances[i] = int.MaxValue;
                unvisited.Add(i);
            }

            distances[0] = 0;

            while (unvisited.Any())
            {
                int current = unvisited.OrderBy(x => distances[x]).First();
                unvisited.Remove(current);

                for (int neighbor = 0; neighbor < adjacencyMatrix.GetLength(1); neighbor++)
                {
                    if (adjacencyMatrix[current, neighbor] != 0)
                    {
                        int alt = distances[current] + adjacencyMatrix[current, neighbor];
                        if (alt < distances[neighbor])
                        {
                            distances[neighbor] = alt;
                            previous[neighbor] = current;
                        }
                    }
                }
            }

            // shortest possible path
            List<int> path = new List<int>();
            int destination = 7;
            while (previous.ContainsKey(destination))
            {
                path.Add(destination);
                destination = previous[destination];
            }
            path.Add(destination);
            path.Reverse();

            // map the colors/numbers into position
            Dictionary<int, string> colors = new Dictionary<int, string>
            {
                {0, "red"},
                {1, "gray"},
                {2, "dark blue"},
                {3, "light blue"},
                {4, "orange"},
                {5, "yellow"},
                {6, "purple"},
                {7, "green"}
            };

            // shortest possible path
            string shortestPath = string.Join(" -> ", path.Select(p => colors[p]));
            Console.WriteLine("Shortest path from red to green: " + shortestPath);
        }
    }
}
