namespace Lesson18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //GenericClass<int> genericClass = new GenericClass<int>();
            //genericClass.Generic(9,7);
            //genericClass.GenericMult(10,11);
            //GenericClass<string> genericClass2 = new GenericClass<string>();
            //genericClass2.GenericString("Text", "Textyan");

            GenericClassTwo<int> generic = new GenericClassTwo<int>();
            generic.Mult(5, 6, 9);

        }
    }
}