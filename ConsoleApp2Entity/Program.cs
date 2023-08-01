using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2Entity
{
    internal class Program
    {

        //console app .net for entity project
        static void Main(string[] args)
        {
            using (var context = new Model())
            {
                User user = new User( "Loginnnn", "5889456");
                context.Users.Add(user);
                context.SaveChanges();
            }
        }
    }
}
