using System;

namespace WpfLesson19
{
    public delegate void Restaurant();

    internal class RestaurantMenu
    {
        public event Restaurant myEvent = null;
        public void InvokeEvent()
        {
            Console.WriteLine("myEvent");
            myEvent.Invoke();
        }
        public void MainDeashes()
        {
            Console.WriteLine("Main Deashes");
        }
    }
}