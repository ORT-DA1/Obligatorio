using Domain.Entities;
using Domain.Interface;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Domain.Repositories
{
    public class WindowRepository : IWindowRepository
    {
        public void Add(Grid grid, Window window)
        {
            using (DatabaseContext _context = new Domain.DatabaseContext())
            {
                _context.Windows.Add(window);
                _context.SaveChanges();
            }
        }

        public int Count(Grid grid)
        {
            throw new NotImplementedException();
        }

        public bool Exist(Grid grid, Window window)
        {
            throw new NotImplementedException();
        }

        public List<Window> GetList(Grid grid)
        {
            using (DatabaseContext _context = new Domain.DatabaseContext())
            {
                return _context.Windows.Where(d => d.GridId == grid.GridId).ToList();
            }
        }

        public void Remove(Grid grid, Window window)
        {
            throw new NotImplementedException();
        }
    }
}
