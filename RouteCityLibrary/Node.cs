using System;
using System.Diagnostics;

namespace RouteCityLibrary
{
    public class Node
    {
        //Method to create the network with random weights between the nodes.
        public int[][] CreateNodeNetwork()
        {
            ShortestDistance sd = new ShortestDistance();
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            int[][] nodeNetwork = SetAllNodeConnectionsToZero();
            int[] connectionsPerNode = SetNumberOfConnectionsPerNode();
            TimeSpan ts = stopWatch.Elapsed;
            for (int i = 0; i < 10; i++)
            {
                Random rand = new Random();
                while (NumberOfConnections(nodeNetwork[i], connectionsPerNode[i]))
                {
                    //using time prevent the loop from being infinite and instead returns CreateNodeNetwork when max time is exceeded
                    if (ts.TotalMilliseconds < 100)
                    {
                        int nodeWeight = rand.Next(1, 11);
                        int nodeToConnect = rand.Next(0, 10);
                        if (nodeToConnect != i && NumberOfConnections(nodeNetwork[nodeToConnect], connectionsPerNode[nodeToConnect]))
                        {
                            nodeNetwork[i][nodeToConnect] = nodeWeight;
                            nodeNetwork[nodeToConnect][i] = nodeWeight;
                        }
                        ts = stopWatch.Elapsed;
                    }
                    else {
                        return CreateNodeNetwork();
                    }

                }
            }
            //checks distance between node 1 and all other nodes to make sure the network is closed, else returns CreateNodeNetwork
            for (int i = 0; i < 10; i++) {
                if (sd.ShortestPath(nodeNetwork, 0, i) > 1000) {
                    return CreateNodeNetwork();
                }
            }
            return nodeNetwork;
        }

        //creates an array where each nodes number of connections is randomized
        private int[] SetNumberOfConnectionsPerNode()
        {
            int[] numberOfConnections = new int[10];
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                numberOfConnections[i] = rand.Next(2, 4);
            }
            return numberOfConnections;
        }

        //checks the number of connections the node already has by counting each value for that node that isn't 0
        private bool NumberOfConnections(int[] node, int numberOfConnections)
        {
            int connections = 0;
            foreach (int connectedNode in node)
            {
                if (connectedNode != 0)
                {
                    connections++;
                }
            }
            if (connections == numberOfConnections)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //creates a 10x10 int array with zero as default value for each node
        private int[][] SetAllNodeConnectionsToZero()
        {
            int[][] collectionOfNodes = new int[10][];
            for (int i = 0; i < 10; i++)
            {
                int[] individualNode = new int[10];
                for (int j = 0; j < 10; j++)
                {
                    individualNode[j] = 0;
                }
                collectionOfNodes[i] = individualNode;
            }
            return collectionOfNodes;
        }
    }
}
