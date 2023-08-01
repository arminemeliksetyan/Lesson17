using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2Entity
{
    internal class User
    {
        //[Key]
        //public int Id { get; set; }
        //[Required]
        //[StringLength(50)]
        //public string FirstName { get; set; }
        //[Required]
        //[StringLength(50)]
        //public string LastName { get; set; }
        //public int Age { get; set; }
        [Required]
        [StringLength(50)]
        public string Login { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }

        public User(string login, string password)
        {
            //Id = id;
            ////FirstName = firstName;
            ////LastName = lastName;
            ////Age = age;
            Login = login;
            Password = password;
        }

        public static string Base64Encode(string Password)
        {
            var textBytes = System.Text.Encoding.UTF8.GetBytes(Password);
            return System.Convert.ToBase64String(textBytes);
        }
        public static string Base64Decode(string base64)
        {
            var base64Bytes = System.Convert.FromBase64String(base64);
            return System.Text.Encoding.UTF8.GetString(base64Bytes);
        }
    }
}
