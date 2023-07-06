using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson17Abstraction
{
    internal class Ak47 : Weapon
    {
        public override void Fire()
        {
            Console.WriteLine("It's Ak 47.");
        }
    }
}
