using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson17
{
    internal class Spring : SeasonsWeather
    {
        public override void Hail()
        {
            Console.WriteLine("hail in Spring.");
        }

        public override void Rain()
        {
            Console.WriteLine("Rain in Spring.");
        }

        public override void Snow()
        {
            Console.WriteLine("Rain in Spring.");
        }

        public override void Tycoon()
        {
            Console.WriteLine("Tycoon in Spring.");
        }
    }
}
