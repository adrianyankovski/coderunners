﻿namespace Uprajnenie5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculate());
            Console.Read();
        }

        public static int Calculate()
        {
            Console.WriteLine("Please enter the first number");
            String number1Input = Console.ReadLine();

            Console.WriteLine("Please enter the second number");
            string number2Input = Console.ReadLine();

            int num1 = int.Parse(number1Input);
            int num2 = int.Parse(number2Input);

            int result = num1 + num2;
            return result;
        }
    }
}