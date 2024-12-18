using CA2.Domain.Entities;
using CA2.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA2.Application.Services
{
    public class UserService : IUserService
    {
        private readonly List<User> _users = new List<User>();

        public void AddUser(User user)
        {
            _users.Add(user);
        }

        public User GetUser(int id)
        {
            return _users.Find(u => u.Id == id);
        }
    }
}
