using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Username:");
            string un = Console.ReadLine();

            User u = new User();
            u.Username = un; ;

            UserContext context = new UserContext();
            context.Users.Add(u);
            context.SaveChanges();

        }
    }

    public class User
    {
        public User user { get; set; }
        
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }

    

}
