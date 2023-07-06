using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Human
    {

        public string firstName = "defaultname";
        public string lastname = "yankovski";

        public void IntroduceMyself()
        {
            Console.WriteLine("Hi, i am " + firstName +" " + lastname);
        }
    }
}
