using System.Collections.Generic;
using Domain.Entities;
using Domain.Logic;

namespace Domain.Interface
{
    public interface IDecorativeColumnRepository
    {
        void Add(Grid grid, DecorativeColumn decorativeColumn, PriceAndCost priceAndCost);
        List<DecorativeColumn> GetList(Grid grid);
        void Remove(Grid grid, DecorativeColumn decorativeColumn);
        int Count(Grid grid);
        bool Exist(Grid grid, Point ubicationPoint);
        DecorativeColumn GetFirst();
    }
}
