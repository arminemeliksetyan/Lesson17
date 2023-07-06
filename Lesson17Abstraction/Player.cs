using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson17Abstraction
{
    internal class Player : Weapon
    {
        public override void Fire()
        {
            Console.WriteLine("I can shoot");
        }

        public void Shoot(Weapon weapon)
        {
            Console.WriteLine("I can shoot in "+ weapon.GetType().Name);
        }
    }
}
