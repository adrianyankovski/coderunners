using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class Box
    {

        public int length;
        public int height;
        public int width;
        public int volume;

        public Box(int length, int height, int width)
        {
            this.length = length;
            this.height = height;
            this.width = width;
            
        }

        public int Height
        {
            get
            {
                return height;
            }
            set
            {   
                if(value < 0)
                {
                    height = -value;
                }
                height = value;
            }
        }
        public void Setlength(int length)
        {
            if(length < 0)
            {
                throw new Exception("length cant be negative");
            }
            this.length = length;
        }

        public int GetLength()
        {
            return this.length;
        }
        public void calculate()
        {
            Console.WriteLine("The 3 dimensions: length {0}, height {1} and width {2}, so the volume is {3}", length, height, width, volume = length * height * width);
   
        }

    }
 
}
