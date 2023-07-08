using System.Drawing;

namespace Lesson18FullOop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] colours = { "Yellow", "Red", "Pink", "White" };
            Nokia electronic1 = new Nokia("8800", 2020, "red");
            electronic1.PhoneParametres = "bcdhj";
            electronic1.PhoneMemory = "120 Gb";
            electronic1.PhoneColours = colours[1];
            electronic1.PrintInfo();
            electronic1.PrintInfoPhone();

            Samsung samsung = new Samsung("Computer", 2022, colours[2]);
            samsung.PrintInfo();
            samsung.ComputerWeight = "1500";
            samsung.ComputerParametrs = "bcjdsb 484cnks";
            samsung.ComputerSize = "17";
            samsung.PrintInfoCompuer();
        }
    }
}