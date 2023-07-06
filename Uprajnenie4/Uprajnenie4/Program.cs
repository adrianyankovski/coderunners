namespace Uprajnenie4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = Add(15, 31);
            Console.WriteLine(result);
            Console.WriteLine(Add(15, 31));
            Console.Read();
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}