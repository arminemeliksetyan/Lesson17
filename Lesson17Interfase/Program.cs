namespace Lesson17Interfase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.Title = "Test";
            book.Description = "Test";
            book.Author = "Test";
            book.Autobiography = "Test";
            book.Print();

        }
    }
}