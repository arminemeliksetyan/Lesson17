using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson19Deligate
{
    public delegate void Action1();

    internal class Wildberies
    {
        public void Choose()
        {
            Console.WriteLine("choose");
        }
        public void Order()
        {
            Console.WriteLine("order");
        }
        public void Pay()
        {
            Console.WriteLine("pay");
        }
        public void Packageing()
        {
            Console.WriteLine("Packageing");
        }
        public void Shipping()
        {
            Console.WriteLine("Shipping");
        }
        public void TaxService()
        {
            Console.WriteLine("tax service");
        }
        public void Delivered()
        {
            Console.WriteLine("Deleveried");
        }
    }
}
