using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    internal class Dictionary
    {
        Dictionary<int, string> dictionary = new Dictionary<int, string>();//generic

        public Dictionary() { }
        //public void State()
        //{
        //    dictionary.Add(1, "Yerevan");
        //    dictionary.Add(2, "Aragacotn");
        //    dictionary.Add(3, "Ararat");
        //    dictionary.Add(4, "Armavir");
        //    dictionary.Add(5, "Gexarquniq");
        //    dictionary.Add(6, "Kotayq");
        //    dictionary.Add(7, "Lori");
        //    dictionary.Add(8, "Shirak");
        //    dictionary.Add(9, "Syuniq");
        //    dictionary.Add(10, "Vayoc dzor");
        //    dictionary.Add(11, "Tavwush");

        //    foreach (var stage in dictionary)
        //    {
        //        Console.WriteLine("HH stage - " + stage.Value);
        //    }

        //    var max = dictionary.MaxBy(m => m.Key);
        //    Console.WriteLine("Max value in dictionary -"+max.Key);
        //}

        List<int> ints = new List<int>();

        public void ListMax()
        {
            ints.Add(4);
            ints.Add(2);
            ints.Insert(0,1);
            ints.AddRange(new List<int> { 1, 1 });

            Console.WriteLine(ints.Max());

            ints.ForEach(x => Console.WriteLine(x));
        }

        Stack<int> stack = new Stack<int>();
        public void StackMax()
        {
            stack.Push(4);
            stack.Push(2);
            stack.Push(3);
            stack.Push(91);
            stack.Push(10);
            stack.Max();

            stack.ToList().ForEach(x => Console.WriteLine(x));

        }
    }
}
