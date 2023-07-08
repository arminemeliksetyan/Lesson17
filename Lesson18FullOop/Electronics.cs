using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson18FullOop
{
    abstract class Electronics
    {
        public string name;
        public int year;
        public string color;
        public Electronics(string name, int year, string color) 
        {
            this.name = name;
            this.year = year;
            this.color = color;
        }

        public abstract void PrintInfo();
        

    }
}
