using System;
using RouteCityLibrary;

namespace RouteCityConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Node nd = new Node();
            int[][] array = nd.CreateNodeNetwork();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(array[i][j]+",");
                }
                Console.WriteLine("");
            }
        }
    }
}
