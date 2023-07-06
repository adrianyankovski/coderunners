using System.Diagnostics.Metrics;

namespace Uprajnenie9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int counter = 0; counter < 10; counter++)
            {
                Console.WriteLine(counter);
            }

            int broqch = 0;

            do
            {
                Console.WriteLine(broqch);
                broqch++;
            } while (broqch < 5);

        }
    }
}