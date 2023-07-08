namespace Lesson18FullOop
{
    internal class Samsung : Electronics, ITablet, IPhone, IComputer
    {
        public Samsung(string name, int year, string color) : base(name, year, color)
        {
        }

        public string TabletParametres { get; set; }

        public string TabletSize { get; set; }

        public string TabletWeight { get; set; }

        public string PhoneParametres { get; set; }

        public string PhoneColours { get; set; }

        public string PhoneMemory { get; set; }

        public string ComputerParametrs { get; set; }

        public string ComputerSize { get; set; }

        public string ComputerWeight { get; set; } 

        public string ComputerColours { get; set; }

        public void PrintInfoTablet()
        {
            Console.WriteLine("Samsung -" + TabletParametres + " " + TabletSize + " " + TabletWeight);
        }
        public void PrintInfoPhone()
        {
            Console.WriteLine("Samsung -" + PhoneParametres + " " + PhoneMemory + " " + PhoneColours);
        }
        public void PrintInfoCompuer()
        {
            Console.WriteLine("Samsung -" + ComputerParametrs + " " + ComputerSize + " " + ComputerWeight + " " + ComputerColours);
        }
        public override void PrintInfo()
        {
            Console.WriteLine("Samsung -" + name, year, color);
        }

    }
}
