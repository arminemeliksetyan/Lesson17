namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Programmer programmer = new Programmer();
            programmer.Name = "Armine";
            programmer.Description = "Unicue";
            programmer.GoToWork = "yes";
            IHuman programmer2 = new Programmer();
            programmer2.Eat();
            

        }
    }
}