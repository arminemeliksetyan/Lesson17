namespace Lesson18FullOop
{
    internal interface IComputer
    {
        string ComputerParametrs { get; }
        string ComputerSize { get; }
        string ComputerWeight { get; }
        string ComputerColours { get; }

        public void PrintInfoCompuer()
        {
            Console.WriteLine("Samsung -" + ComputerParametrs, ComputerSize, ComputerWeight, ComputerColours);
        }

    }
}
