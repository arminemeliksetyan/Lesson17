using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson19Deligate
{
    public delegate int DelegatePay(out int a);
    internal class PayTransfer
    {
        public int ShipPay(out int a)
        {
            a = 8000;
            Console.WriteLine("ShipPay " + (a += 1000));
            return a;
        }
        public int PackageingPay(out int a)
        {
            a = ShipPay(out a);
            Console.WriteLine("PackageingPay " + (a += 500));
            return a;
        }
        public int DeliveringPay(out int a)
        {
            a = PackageingPay(out a);
            Console.WriteLine("DeliveringPay " + (a += 500));
            return a;
        }

    }
}
