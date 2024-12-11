using CA1.Application.Services;
using CA1.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA1.Presentation
{
    public class ConsoleApp
    {
        public void App() {
            var userService = new UserService();

            // Adding a user
            var user = new User { Id = 1, Name = "Moses", Email = "moses@allah.com" };
            userService.AddUser(user);
            Console.WriteLine("User added: " + user.Name);
            userService.AddUser(new User() { Id = 2, Name = "Zaman", Email = "zaman@earth.com" });
            Console.WriteLine("User added");

            // Retrieving a user
            var retrievedUser = userService.GetUser(1);
            Console.WriteLine("Retrieved User: " + retrievedUser.Name + ", Email: " + retrievedUser.Email);
            retrievedUser = userService.GetUser(2);
            Console.WriteLine("Retrieved User: " + retrievedUser.Name + ", Email: " + retrievedUser.Email);
        }
    }
}
