using Domain.Entities;
using Domain.Interface;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Data.Entity;

namespace Domain.Repositories
{
    public class WindowRepository : IWindowRepository
    {
        public DatabaseContext _context;
        public WindowRepository(GridRepository gridRepository)
        {
            this._context = gridRepository._context;
        }
        public void Add(Grid grid, Window window, PriceAndCost priceAndCost)
        {
            PriceAndCost priceCost = _context.PricesAndCosts
                .Where(w => w.PriceAndCostId == priceAndCost.PriceAndCostId)
                .FirstOrDefault();
            window.PriceAndCost = priceCost;
            _context.Grids.Attach(grid);
            window.Grid = grid;
            _context.Windows.Add(window);
            _context.SaveChanges();
        }

        public int Count(Grid grid)
        {
            return this.GetList(grid).Count;
        }

        public bool Exist(Grid grid, Point ubicationPoint)
        {
            Window windowToFind = null;
            windowToFind = _context.Windows
                .Where(w => (w.Grid.GridId == grid.GridId
                && w.StartPoint.X == ubicationPoint.X)
                && w.StartPoint.Y == ubicationPoint.Y)
                .FirstOrDefault();

            return !(windowToFind == null);
        }

        public Window GetFirst()
        {
            return _context.Windows.Where(w => w.WindowId == 1).FirstOrDefault();
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

        public List<string> GetNameList()
        {
            List<string> listName = new List<string>();
            var names = from window in _context.Windows
                        select new { window.name };

            foreach (var name in names)
            {
                if (!listName.Contains(name.ToString()))
                {
                    listName.Add(name.ToString());
                }
            }
            return listName;
        }

        public Window GetWindow(Window window)
        {
            return _context.Windows
                .Where(w => w.WindowId == window.WindowId)
                .Include("StartPoint")
                .Include("EndPoint")
                .FirstOrDefault();
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
