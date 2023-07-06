namespace OOP5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int[] grades = new int[5];

            grades[0] = 20;
            grades[1] = 30;
            grades[2] = 12;
            grades[3] = 9;
            grades[4] = 10;
            string input = Console.ReadLine();
            grades[0] = int.Parse(input);
            Console.WriteLine("grades at index 0: {0}", grades[0]);
            int[] gradesofMathStudentsA = { 20, 13, 12, 8, 8 };

            int[] gradesOfMathStudentssB = new int[] { 15, 20, 3, 17, 18, 15 };

            Console.WriteLine("Length of gradesofMathStydentssA : {0}", gradesofMathStudentsA.Length);
        }
    }
}