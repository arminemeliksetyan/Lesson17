using System.Security.Cryptography;

namespace Lesson19Deligate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Wildberies wildberies = new Wildberies();
            Action1 action = new Action1(wildberies.Choose);
            action += wildberies.Order;
            action += wildberies.Pay;
            action += wildberies.Packageing;
            action += wildberies.Shipping;
            action += wildberies.TaxService;
            action += wildberies.Delivered;
            action.Invoke();

            int money;
            PayTransfer transfer = new PayTransfer();
            DelegatePay delegatePay = new DelegatePay(transfer.ShipPay);
            delegatePay += transfer.PackageingPay;
            delegatePay += transfer.DeliveringPay;
            delegatePay.Invoke(out money);
            Console.WriteLine("Your pay is - "+money);

        }
    }
}