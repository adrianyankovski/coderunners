namespace Uprajnenie2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float vat = 19f;
            float pA = 3.99f;
            float pB = 11.99f;
            float pC = 5.75f;

            float summed = pA + pB + pC;

            float totalTax = (summed / 100) * vat;

            summed += totalTax;

            Console.WriteLine("TotaL PRICE IS: " + summed);
        }
    }
}