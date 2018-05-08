using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Interface
{
    public interface IUserHandler<T>
    {
        T Get(T globalObject);
        void Add(T globalObject);
        void Delete(T globalObject);
        void Modify(T globalObject, T anotherGlobalObject);
        void Exist(T globalObject);
        void Validate(T globalObject);
        bool ValidateLogin(string username, string password);
    }
}
