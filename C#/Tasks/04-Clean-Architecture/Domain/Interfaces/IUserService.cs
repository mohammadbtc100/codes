using CA1.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA1.Domain.Interfaces
{
    public interface IUserService
    {
        void AddUser(User user);
        User GetUser(int id);
    }
}
