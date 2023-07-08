namespace Lesson18FullOop
{
    internal interface ITablet
    {
        string TabletParametres { get; }
        string TabletSize { get; }
        string TabletWeight { get; }

        public void PrintInfoTablet()
        {
            Console.WriteLine("Samsung -" + TabletParametres, TabletSize, TabletWeight);
        }
    }
}
