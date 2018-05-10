using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface
{
    public interface IUserHandler<User>
    {
        void Add(User user);
        void Delete(User user);
        void Modify(User user, User anotherUser);
        void Exist(User user);
        void Validate(User user);
    }
}
