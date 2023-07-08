using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson18
{
    internal class GenericClass<T>
    {
        public GenericClass() { }
        public void Generic<T>(T t, T b)
        {
            dynamic dynamic1 = t;
            dynamic dynamic2 = b;

            Console.WriteLine(dynamic1 + dynamic2);
        }

        public void GenericMult<T>(T t, T z)
        {
            dynamic d1 = t;
            dynamic d2 = z;

            Console.WriteLine(d1 * d2);
        }

        public void GenericString<T>(T t, T v)
        {
            Console.WriteLine(t + " " + v);
        }
    }
}
