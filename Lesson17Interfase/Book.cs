using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson17Interfase
{
    internal class Book : IBook
    {
        public Book() { }
        public string Title { get; set; }

        public string Description { get; set; }

        public string Author { get; set; }

        public string Autobiography { get; set; }

        public void Print()
        {
            Console.WriteLine(Title + " " + Description + " " + Author + " " + Autobiography);
        }
    }
}
