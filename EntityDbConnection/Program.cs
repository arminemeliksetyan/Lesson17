using EntityDbConnection.Users;

namespace EntityDbConnection
{
    internal class Program
    {
            //PM> Scaffold-DbContext "Server=DESKTOP-QCOA7R0\SQLEXPRESS;Database=registration;Trusted_Connection=True;TrustServerCertificate=True" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Users

        
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            AddUser(1, "Anna", "AnnaAvetyan",11,"login1", "123456");
   
        }

        static void AddUser(int id, string firstname, string lastname, int age, string login, string pass)
        {
            var context = new registrationContext();
            var user = new User { Id = id, FirstName = firstname, LastName=lastname, Age=age, Login = login, Password = pass };
            context.Add(user);
            context.SaveChanges();
        }
    }
}