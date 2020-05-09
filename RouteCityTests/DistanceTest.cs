using System;
using System.Collections.Generic;
using System.Text;
using RouteCityLibrary;
using NUnit.Framework;

namespace RouteCityTests
{
    public class DistanceTest
    {
        private readonly int[][] testNodeNetwork = new int[10][]{
                            new int[]{ 0, 4, 0, 0, 0, 0, 0, 8, 0, 10 },
                            new int[]{ 4, 0, 0, 1, 0, 0, 8, 0, 0, 0 },
                            new int[]{ 0, 0, 0, 6, 0, 0, 0, 0, 8, 0 },
                            new int[]{ 0, 1, 6, 0, 0, 0, 0, 0, 0, 0 },
                            new int[]{ 0, 0, 0, 0, 0, 6, 7, 0, 0, 5 },
                            new int[]{ 0, 0, 0, 0, 6, 0, 0, 0, 2, 6 },
                            new int[]{ 0, 8, 0, 0, 7, 0, 0, 0, 0, 0 },
                            new int[]{ 8, 0, 0, 0, 0, 0, 0, 0, 8, 0 },
                            new int[]{ 0, 0, 8, 0, 0, 2, 0, 8, 0, 0 },
                            new int[]{ 10, 0, 0, 0, 5, 6, 0, 0, 0, 0 }
                            };

        [Test]
        public void TestShortestPathBetweenTwoNodes()
        {
            ShortestDistance sd = new ShortestDistance();

            int source = 0;
            int target = 9;
            int shortestPath = sd.ShortestPath(testNodeNetwork, source, target)[0][0];
            Assert.AreEqual(10, shortestPath);
        }
        [Test]
        public void TestShortestPathBetweenTheSameNode()
        {
            ShortestDistance sd = new ShortestDistance();

            int source = 0;
            int target = 0;
            int shortestPath = sd.ShortestPath(testNodeNetwork, source, target)[0][0];
            Assert.AreEqual(0, shortestPath);
        }
    }
}

