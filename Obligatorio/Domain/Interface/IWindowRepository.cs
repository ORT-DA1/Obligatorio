using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Interface
{
    public interface IWindowRepository
    {
        void Add(Grid grid, Window window, PriceAndCost priceAndCost);
        List<Window> GetList(Grid grid);
        int Count(Grid grid);
        bool Exist(Grid grid, Point ubicationPoint);
        void Remove(Grid grid, Window window);
        Window GetFirst();
        List<string> GetNameList();
    }
}
