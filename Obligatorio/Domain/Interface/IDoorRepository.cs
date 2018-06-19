using System.Collections.Generic;
using Domain.Entities;
using Domain.Logic;

namespace Domain.Interface
{
    public interface IDoorRepository
    {
        void Add(Grid grid, Door door);
        List<Door> GetList(Grid grid);
        void Remove(Grid grid, Door door);
        bool Exist(Door door);
        int Count(Grid grid);
    }
}
