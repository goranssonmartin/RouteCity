﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RouteCityLibrary
{
    public class ShortestDistance
    {
        public static int start = 0;

        private static int MinDistanceBetweenNodes()
        {
            return 0;
        }

        public static void ShortestPath()
        {

        }


        //private static int MinimumDistance(int[] distance, bool[] shortestPathTreeSet, int verticesCount)
        //{
        //    int min = int.MaxValue;
        //    int minIndex = 0;
        //
        //    for (int v = 0; v < verticesCount; ++v)
        //    {
        //        if (shortestPathTreeSet[v] == false && distance[v] <= min)
        //        {
        //            min = distance[v];
        //            minIndex = v;
        //        }
        //    }
        //
        //    return minIndex;
        //}

        //public static void DijkstraAlgo(int[,] graph, int source, int verticesCount)
        //{
        //    int[] distance = new int[verticesCount];
        //    bool[] shortestPathTreeSet = new bool[verticesCount];
        //
        //    for (int i = 0; i < verticesCount; ++i)
        //    {
        //        distance[i] = int.MaxValue;
        //        shortestPathTreeSet[i] = false;
        //    }
        //
        //    distance[source] = start;
        //
        //    for (int count = 0; count < verticesCount - 1; ++count)
        //    {
        //        int u = MinimumDistance(distance, shortestPathTreeSet, verticesCount);
        //        shortestPathTreeSet[u] = true;
        //
        //        for (int v = 0; v < verticesCount; v++)
        //            if (!shortestPathTreeSet[v] && Convert.ToBoolean(graph[u, v]) && distance[u] != int.MaxValue && distance[u] + graph[u, v] < distance[v])
        //                distance[v] = distance[u] + graph[u, v];
        //    }
        //}
    }
}

