namespace Uprajnenie8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tempreature = -5;
            string stateOfMatter;

            if (tempreature < 0)
                stateOfMatter = "solid";
            else
                stateOfMatter = "liquid";

            stateOfMatter = tempreature < 0 ? "solid" : "liquid";
            stateOfMatter = tempreature > 100 ? "gas" : tempreature < 0 ? "solid" : "liquid";
        }

        
    }
}