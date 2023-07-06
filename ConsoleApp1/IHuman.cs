using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal interface IHuman
    {
        string Name { get; }
        string Description { get; }
        string GoToWork { get; }
        string Eat()
        {
            return "eat";
        }
    }
}
