using Domain.Entities;
using Domain.Interface;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Repositories
{
    public class WindowRepository : IWindowRepository
    {
        public void AddWindow(Grid grid, Window window)
        {
            using (DatabaseContext _context = new Domain.DatabaseContext())
            {
                _context.Windows.Add(window);
                _context.SaveChanges();
            }
        }

        public List<Window> GetAllWindows(Grid grid)
        {
            using (DatabaseContext _context = new Domain.DatabaseContext())
            {
                return _context.Windows.Where(d => d.GridId == grid.GridId).ToList();
            }
        }

    }
}
