using System.Net.Http.Headers;

namespace Uprajnenie12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] matrix;

            int[,,] threedD;

            int[,] array2D = new int[,]
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            foreach (int item in array2D)
            {
                Console.Write(item + " ");
            }

            for (int i = 0; i < array2D.GetLength(0); i++)
            {
                for (int j = 0; j < array2D.GetLength(1); j++)
                {
                
                    Console.Write(array2D[i, j] + " ");
                }
            }

            Console.WriteLine("Value is {0}", array2D[2, 0]);

            string[,,] array3D= new String[,,]
            {
                {
                    { "000", "001"},
                    { "010", "011"
                    }
                },
                {
                    {"100", "101" },
                    {"110", "111" }
                }
            };

            Console.WriteLine("Value is {0}", array3D[1,1,0]);
        }
    }
}
