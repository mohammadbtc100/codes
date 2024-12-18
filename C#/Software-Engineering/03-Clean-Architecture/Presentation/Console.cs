using CA2.Application.Services;
using CA2.Domain.Entities;
using CA2.Domain.Interfaces;
using CA2.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA2.Presentation
{
    public class ConsoleApp
    {
        public void App() {
            // Set up Dependency Injection and Entity Framework Core with SQLite.
            var serviceProvider = new ServiceCollection()
                .AddDbContext<AppDbContext>(options =>
                    options.UseSqlite("Data Source=users.db"))
                .AddScoped<IUserService, UserService>()
                .BuildServiceProvider();

            // Create the database and add a user.
            using (var scope = serviceProvider.CreateScope())
            {
                var userService = scope.ServiceProvider.GetRequiredService<IUserService>();

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

            Console.ReadLine();
          
            
        }
    }
}
