namespace Lesson18FullOop
{
    internal interface IPhone
    {
        string PhoneParametres { get; }
        string PhoneColours { get; }
        string PhoneMemory { get; }

        public void PrintInfoPhone()
        {
            Console.WriteLine("Samsung -" + PhoneParametres, PhoneMemory, PhoneColours);
        }
    }
}
