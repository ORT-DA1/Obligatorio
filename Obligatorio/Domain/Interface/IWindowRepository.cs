using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Interface
{
    public interface IWindowRepository
    {
        void Add(Grid grid, Window window);
        List<Window> GetList(Grid grid);
        int Count(Grid grid);
        bool Exist(Grid grid, Window window);
        void Remove(Grid grid, Window window);
    }
}
