namespace Uprajnenie11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int[] nums = new int[10];

            for (int j = 0; j < nums.Length; j++)
            {
                Console.WriteLine("Element{0} = {1}", j, nums[j]);
            }
            int counter = 0;
            foreach (int x in nums)
            {
                Console.WriteLine("Element{0} = {1}", counter, x);
            }

            string[] myFreinds = { "Michael", "Wlad", "Ilija" };
            
            foreach (string name in myFreinds) {
                Console.WriteLine("Hi there {0}, my friend", name);
            }
        }
    }
}