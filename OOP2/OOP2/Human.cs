using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class Human
    {

        private string firstName;
        private string lastName;
        private string eyecolor;
        private int age;
       

        public Human(string firstName, string lastName, string eyecolor, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyecolor = eyecolor;
            this.age = age;
            
        }

        public Human(string firstName, string lastName, string eyecolor)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyecolor = eyecolor;
           
        }

        public Human()
        {
            Console.WriteLine("Napraihme choek");
        }

        public void IntroduceMyself()
        {   if (age != 0)
            {
                Console.WriteLine("Hi, i am {0} {1} at {2}. MY eye color is {3}", firstName, lastName, age, eyecolor);
            }
            else
            {
                Console.WriteLine("Hi, i am {0} {1}. MY eye color is {2}", firstName, lastName, eyecolor);
            }
        }

    }
}
