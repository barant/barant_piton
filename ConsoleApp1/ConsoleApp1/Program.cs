using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (UserBase user = new UserBase())
            {
                User u = new User();
                u.Name = "brnt";
                user.Users.Add(u);
                user.SaveChanges();
                Console.WriteLine("New user added.");
                user.Users.ToList().ForEach(x =>
                {
                    Console.WriteLine("Username : {0}", x.Name);
                });

                User uUpdate = user.Users.SingleOrDefault(x => x.Name == "brnt");
                uUpdate.Name = "barant";
                user.SaveChanges();
                Console.WriteLine("Updated.");
                user.Users.ToList().ForEach(x =>
                {
                    Console.WriteLine("Username : {0}", x.Name);
                });

                User uDelete = user.Users.SingleOrDefault(x => x.Name == "barant");
                user.Users.Remove(uDelete);
                user.SaveChanges();
                Console.WriteLine("Deleted.");

            }

            Console.ReadLine();
            
        }
    }
}
