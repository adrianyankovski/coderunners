namespace Uprajnenie6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            // !vsicko no
            //++A na momenta +1
            //A++ sled tova +1
            //A--, --A, raboti po sushtiq nachin
            // int a, int b = -a, obrushta stoinostta.
            // A $ B, deli a na B i zakruglq ostatuka.

            bool isLower;
            isLower = 5 > 3;
            Console.WriteLine(isLower);
            Console.WriteLine("Rezulata", isLower);
            Console.WriteLine("Rezulata {0}", isLower);

            //int tempreature = 10;
            Console.WriteLine("Wahts the tempretautre like?");
            string temperature = Console.ReadLine();
            int tempreature;
            int nomber;

            if(int.TryParse(temperature, out nomber))
            {
                tempreature = nomber;
            }
            else
            {
                tempreature = 0;
            }

            if(tempreature < 10)
            {
                Console.WriteLine("Vzemi si qketo");
            }

            if(tempreature == 10)
            {
                Console.WriteLine("10 gradusa e");
            }
            else
            {
                Console.WriteLine("Toplichko e");
            }
        }
    }
}