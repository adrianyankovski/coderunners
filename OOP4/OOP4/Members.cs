using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4
{
    internal class Members
    {

        private string memberName;
        private string jobTitle;
        private int Salary;

        public int age;

        public string JobTitle
        {
            get { return jobTitle; }
            set { jobTitle = value; }
        }

        public void Introducing(bool isFriend)
        {
            if(isFriend)
            {
                SharingPrivateInfo();
            }
            else
            {
                Console.WriteLine("Hi, my name is {0}, and my job title is {1}. I am {2} years old", memberName, jobTitle, age);           
            }

        }

        private void SharingPrivateInfo()
        {
            Console.WriteLine("Ny salary is {0}", Salary);
        }

        public Members()
        {
            age = 30;
            memberName = "lucy";
            Salary = 60000;
            jobTitle = "developer";
            Console.WriteLine("Object Created");
        }

        ~Members()
        {
            //destructor
            Console.WriteLine("class destructed");
            Debug.Write("Desturction");
        }
    }
}
