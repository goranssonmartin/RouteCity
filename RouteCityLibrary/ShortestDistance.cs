using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace RouteCityLibrary
{
    public class ShortestDistance
    {

       

        //Source is the starting point and target the choosen node to find the shortest path between them.
        public int ShortestPath(int[][] nodeNetwork, int source, int target)
        {
            int[] distance = new int[10];
            bool[] shortestPathTreeSet = new bool[10];

            for (int i = 0; i < 10; i++)
            {
                distance[i] = int.MaxValue;
                shortestPathTreeSet[i] = false;
            }

            distance[source] = 0;

            for (int count = 0; count < 10 - 1; count++)
            {
                int u = MinDistanceBetweenNodes(distance, shortestPathTreeSet);
                shortestPathTreeSet[u] = true;
                for (int v = 0; v < 10; v++)
                {
                    if (!shortestPathTreeSet[v] && Convert.ToBoolean(nodeNetwork[u][v]) && distance[u] != int.MaxValue && distance[u] + nodeNetwork[u][v] < distance[v])
                        distance[v] = distance[u] + nodeNetwork[u][v];
                }
            }
            return distance[target];
        }

        private static int MinDistanceBetweenNodes(int[] distance, bool[] shortestPathTreeSet)
        {
            int min = int.MaxValue;
            int minIndex = 0;

            for (int v = 0; v < 10; v++)
            {
                if (shortestPathTreeSet[v] == false && distance[v] <= min)
                {
                    min = distance[v];
                    minIndex = v;
                }
            }

            return minIndex;
        }
    }
}

