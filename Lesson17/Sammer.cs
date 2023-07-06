using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson17
{
    internal class Sammer : Weather
    {
        public override void Hail()
        {
            Console.WriteLine("Hail in Summer.");
        }

        public override void Rain()
        {
            Console.WriteLine("Rain in Summer.");
        }

        public override void Temperature()
        {
            throw new NotImplementedException();
        }

        public override void Tycoon()
        {
            Console.WriteLine("Tycoon in Summer.");
        }

        public override void Windly()
        {
            throw new NotImplementedException();
        }
    }
}
