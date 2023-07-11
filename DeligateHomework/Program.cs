namespace DeligateHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RestaurantMenu menu = new RestaurantMenu();
            //RestaurantDeligate restaurantDeligate = new RestaurantDeligate(menu.MainDeashes);
            //restaurantDeligate += menu.IceCream;
            //restaurantDeligate += menu.HotDeashes;
            //restaurantDeligate.Invoke();

            //MenuCost menuCost = new MenuCost();
            //CostMenuDeligate cost = new CostMenuDeligate(menuCost.CostHotDeases);
            //cost += menuCost.CostIceCream;
            //cost += menuCost.CostMainDeashes;
            //cost.Invoke(1500);

            menu.myEvent += new RestaurantDeligate(menu.MainDeashes);
            menu.InvokeEvent();

        }
    }
}