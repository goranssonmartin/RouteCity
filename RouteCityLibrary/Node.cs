using System;

namespace RouteCityLibrary
{
    public class Node
    {
        //Method to create the network with random weights between the nodes.
        public int[][] CreateNodeNetwork()
        {
            int[][] nodeNetwork = SetAllValuesToZero();
            int[] connectionsPerNode = SetNumberOfConnectionsPerNode();

            for (int i = 0; i < 10; i++)
            {
                Random rand = new Random();
                while (NumberOfConnections(nodeNetwork[i], connectionsPerNode[i]))
                {
                    int nodeWeight = rand.Next(0, 11);
                    int nodeToConnect = rand.Next(0, 10);
                    if (nodeToConnect != i && NumberOfConnections(nodeNetwork[nodeToConnect], connectionsPerNode[nodeToConnect]))
                    {
                        nodeNetwork[i][nodeToConnect] = nodeWeight;
                        nodeNetwork[nodeToConnect][i] = nodeWeight;
                    }

                }
            }
            return nodeNetwork;
        }


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

        private bool NumberOfConnections(int[] node, int numberOfConnections)
        {
            int connections = 0;
            foreach (int conn in node)
            {
                if (conn != 0)
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

        private int[][] SetAllValuesToZero()
        {
            int[][] returnArray = new int[10][];
            for (int i = 0; i < 10; i++)
            {
                int[] row = new int[10];
                for (int j = 0; j < 10; j++)
                {
                    row[j] = 0;
                }
                returnArray[i] = row;
            }
            return returnArray;
        }
    }
}
