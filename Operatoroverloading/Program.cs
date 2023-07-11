namespace Operatoroverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    class Class1
    {
        int[] numbers1 = { 1, 2, 3 };
        int[] numbers2 = { 1, 2, 3 };
        public static Class1 operator+(Class1 class1, Class1 class2)
        {
            Class1 class3 = new Class1();
            class3 = class1.numbers1 + class2.numbers2;
            return class3;
        }
    }
}