using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalStorage.Interface
{
    public interface IGlobalStorageHandler<T>
{
        T Get(T globalObject);
        List<T> GetCollection();
        void Save(T globalObject);
        void Modify(T globalObject, T anotherGlobalObject);
        void Delete(T globalObject);
        bool Exist(T globalObject);
}
} 
