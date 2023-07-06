namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human denis = new Human();
            denis.firstName = "Denis";
            denis.IntroduceMyself();

            Human michael = new Human();

            michael.IntroduceMyself();

            Human adrian = new Human();
            adrian.firstName = "adrian";
            adrian.lastname = "yankovskei";
            adrian.IntroduceMyself();


            Console.ReadKey();
        }
    }
}