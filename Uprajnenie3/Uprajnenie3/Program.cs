using System.Transactions;

namespace Uprajnenie3
{
    internal class Program
    {

        float price = 3.99f;
        string name = "Adrian";
        char letter = 'a';
        int number = 1000;
        bool toggle = true;
        //var stava za vsichko
        static void Main(string[] args)
        {
            WriteSomething("Adrian");
        }

        public static void WriteSomething(string Adrian)
        {
            Console.WriteLine("I am a called from a method : " + Adrian);
            Console.Read();
        }
    }
}