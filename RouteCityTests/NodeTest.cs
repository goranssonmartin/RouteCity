using NUnit.Framework;
using RouteCityLibrary;

namespace RouteCityTests
{
    public class Tests
    {

        [Test]
        public void TestThatAllNodesHaveTwoOrThreeConnections()
        {
            Node nd = new Node();
            int[][] testArray = nd.CreateNodeNetwork();
            for (int i = 0; i < 10; i++)
            {
                int counter = 0;
                bool correctNumberOfConnections = false;
                for (int j = 0; j < 10; j++)
                {
                    if (testArray[i][j] != 0)
                    {
                        counter++;
                    }
                }
                if (counter == 2 || counter == 3)
                {
                    correctNumberOfConnections = true;
                }
                Assert.IsTrue(correctNumberOfConnections);
            }
        }

        [Test]
        public void TestThatWeightBetweenNodesHasCorrectValue()
        {
            Node nd = new Node();
            int[][] testArray = nd.CreateNodeNetwork();
            for (int i = 0; i < 10; i++)
            {
                int counter = 0;
                bool correctNumberOfConnections = false;
                bool correctValue = true;
                for (int j = 0; j < 10; j++)
                {
                    if (testArray[i][j] != 0)
                    {
                        counter++;
                    }

                    if (testArray[i][j] < 0 || testArray[i][j] > 10)
                    {
                        correctValue = false;
                    }
                }
                if (counter == 2 || counter == 3)
                {
                    correctNumberOfConnections = true;
                }
                Assert.IsTrue(correctNumberOfConnections);
                Assert.IsTrue(correctValue);
            }
        }
    }
}