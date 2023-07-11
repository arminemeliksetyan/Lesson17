using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeligateHomework
{
    public delegate int CostMenuDeligate(int i);
    internal class MenuCost
    {
        public int CostMainDeashes(int i)
        {
            Console.WriteLine("Cost main deashes" + i);
            return i;
        }
        public int CostHotDeases(int i)
        {
            Console.WriteLine("Cost hot deashes" + i);
            return i;
        }
        public int CostIceCream(int i)
        {
            Console.WriteLine("Cost ice cream" + i);
            return i;
        }
    }
}
