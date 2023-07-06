namespace Lesson17Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Weapon[] weapons = { new Gun(), new LazerGun(), new Ak47() };
            Weapon gun = new Gun();
            Weapon lazerGun = new LazerGun();
            Weapon ak47 = new Ak47();

            Console.WriteLine("\n");

            gun.Fire();
            lazerGun.Fire();
            ak47.Fire();

            Console.WriteLine("\n");

            player.Shoot(gun);
            player.Shoot(lazerGun);
            player.Shoot(ak47);

            Console.WriteLine("\n");

            foreach (Weapon weapon in weapons)
            {
                player.Shoot(weapon);
            }

        }
    }
}