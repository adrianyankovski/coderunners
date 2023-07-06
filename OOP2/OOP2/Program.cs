namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human pesho = new Human("Petur", "Zdravkov", "green");
            pesho.IntroduceMyself();
            Human adrian = new Human("adrian", "yankovski", "green", 10);
            adrian.IntroduceMyself();
        }
    }
}