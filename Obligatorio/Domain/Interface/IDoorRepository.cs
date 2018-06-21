using System.Collections.Generic;
using Domain.Entities;
using Domain.Logic;

namespace Domain.Interface
{
    public interface IDoorRepository
    {
        void Add(Grid grid, Door door, PriceAndCost priceAndCost);
        List<Door> GetList(Grid grid);
        void Remove(Grid grid, Door door);
        int Count(Grid grid);
        bool Exist(Grid grid, Point startPoint);
        Door GetFirst();
    }
}
