using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeligateHomework
{
    public delegate void RestaurantDeligate();
    internal class RestaurantMenu
    {
        public event RestaurantDeligate myEvent = null;
        public void InvokeEvent()
        {
            Console.WriteLine("myEvent");
            myEvent.Invoke();
        }
        public void MainDeashes()
        {
            Console.WriteLine("Main Deashes");
        }

        public void HotDeashes()
        {
            Console.WriteLine("Hot Deashes");
        }

        public void IceCream()
        {
            Console.WriteLine("Ise cream");
        }
    }
}
