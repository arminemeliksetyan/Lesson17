using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson17
{
    internal class Winter : SeasonsWeather
    {
        public override void Hail()
        {
            Console.WriteLine("Hail in Winter.");
        }

        public override void Rain()
        {
            Console.WriteLine("Rain in Winter.");
        }

        public override void Snow()
        {
            Console.WriteLine("Snow in Winter.");
        }

        public override void Tycoon()
        {
            Console.WriteLine("Tycoon in Winter.");
        }
    }
}
