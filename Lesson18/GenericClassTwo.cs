using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson18
{
    internal class GenericClassTwo<G>
    {
        public GenericClassTwo() { }
        public void Mult<G> (G g, G a, G b) 
        {
            dynamic dynamic1 = g;
            dynamic dynamic2 = a;
            dynamic dynamic3 = b;
            Console.WriteLine(dynamic1 * dynamic2 * dynamic3);
        }
    }
}
