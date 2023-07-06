namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Box box = new Box(1, 2, 5);
            box.Setlength(10);
            box.Height = 2;
            box.calculate();
            Console.WriteLine(box.GetLength());
            Console.WriteLine(box.Height);
        }
    }
}