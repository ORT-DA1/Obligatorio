using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Interface
{
    public interface IWindowRepository
    {
        void AddWindow(Grid grid, Window window);
        List<Window> GetAllWindows(Grid grid);
    }
}
