using Domain.Entities;
using Domain.Interface;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Domain.Repositories
{
    public class WindowRepository : IWindowRepository
    {
        public DatabaseContext _context;
        public WindowRepository(GridRepository gridRepository)
        {
            this._context = gridRepository._context;
        }
        public void Add(Grid grid, Window window)
        {
            window.Grid = grid;
            _context.Windows.Add(window);
            _context.SaveChanges();
        }

        public int Count(Grid grid)
        {
            return this.GetList(grid).Count;
        }

        public bool Exist(Grid grid, Window window)
        {
            Window windowToFind = null;
            windowToFind = _context.Windows.Where(w => (w.Grid.GridId == grid.GridId
            && w.StartPoint == window.StartPoint)).FirstOrDefault();

            return !(windowToFind == null);
        }

        public List<Window> GetList(Grid grid)
        {
            try
            {
                List<Window> windowList = null;
                windowList = _context.Windows
                    .Where(w => w.Grid.GridId == grid.GridId)
                    .ToList();

                return windowList;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public void Remove(Grid grid, Window window)
        {
            Window windowToDelete = null;
            windowToDelete = _context.Windows
                .Where(w =>
                (w.Grid.GridId == grid.GridId && w.WindowId == window.WindowId))
                .FirstOrDefault();

            _context.Windows.Remove(windowToDelete);
            _context.SaveChanges();

        }
    }
}
