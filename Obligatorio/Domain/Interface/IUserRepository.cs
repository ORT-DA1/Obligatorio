using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Interface
{
    public interface IUserRepository
    {
        void UserExists(String username, String password);
        User GetUser(String username);
    }
}
