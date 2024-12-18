using CA2.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA2.Domain.Interfaces
{
    public interface IUserService
    {
        void AddUser(User user);
        User GetUser(int id);
    }
}
