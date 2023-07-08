using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson18FullOop
{
    internal class Nokia : Electronics, IPhone
    {
        public Nokia(string name, int year, string color) : base(name, year, color)
        {
        }

        public string PhoneParametres { get; set; }

        public string PhoneColours { get; set; }

        public string PhoneMemory { get; set; }

        public void PrintInfoPhone()
        {
            Console.WriteLine("Nokia -" + PhoneParametres+" " +PhoneColours +" "+ PhoneMemory);
        }

        public override void PrintInfo()
        {
            Console.WriteLine("Nokia -" + name+ " "+ year+ " " +color);
        }
    }
}
