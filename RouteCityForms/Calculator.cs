using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteCityForms
{
    class Calculator
    {
        //Calculates which anchors are closest of two given nodes, to avoid as many overlaps on the node itself
        public static int[] GetClosestAnchorPointsOfTwoGivenNodes(Coordinates startPoint, Coordinates endPoint)
        {
            int[] anchorIndex = new int[2];
            double shortestDistance = 1000;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    double xCoordStartAnchor = startPoint.anchorPoints[i][0];
                    double yCoordStartAnchor = startPoint.anchorPoints[i][1];
                    double xCoordEndAnchor = endPoint.anchorPoints[j][0];
                    double yCoordEndAnchor = endPoint.anchorPoints[j][1];
                    double distance = Math.Sqrt(Math.Pow((xCoordEndAnchor - xCoordStartAnchor), 2) + Math.Pow((yCoordEndAnchor - yCoordStartAnchor), 2));
                    if (distance <= shortestDistance)
                    {
                        anchorIndex[0] = i;
                        anchorIndex[1] = j;
                        shortestDistance = distance;
                    }
                }
            }
            return anchorIndex;
        }

        //finds the coordinates at the middle of a line between two nodes
        public static int[] GetMiddleOfLine(int[] startNode, int[] endNode)
        {
            int[] middlePoint = new int[2];
            middlePoint[0] = ((startNode[0] + endNode[0]) / 2);
            middlePoint[1] = ((startNode[1] + endNode[1]) / 2);
            return middlePoint;
        }

    }
}
