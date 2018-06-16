using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Interface
{
    public interface IUserHandler<User>
    {
        User Get(User user);
        void Add(User user);
        void Modify(User user);
        void Delete(User user);
        void Exist(User user);
        void LookForUser(String username, String password);
        void Validate(User user);
        List<User> GetList();
    }
}
