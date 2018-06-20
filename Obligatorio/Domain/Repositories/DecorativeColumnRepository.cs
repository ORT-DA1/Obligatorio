using Domain.Entities;
using Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Repositories
{
    public class DecorativeColumnRepository : IDecorativeColumnRepository
    {
        public void Add(Grid grid, DecorativeColumn decorativeColumn)
        {
            using (DatabaseContext _context = new Domain.DatabaseContext())
            {
                _context.Grids.Attach(grid);
                decorativeColumn.Grid = grid;
                _context.DecorativeColumns.Add(decorativeColumn);
                _context.SaveChanges();
            }
        }

        public int Count(Grid grid)
        {
            return this.GetList(grid).Count;
        }
        
        public bool Exist(Grid grid, DecorativeColumn decorativeColumn)
        {
            DecorativeColumn decorativeColumnToFind = null;
            using (DatabaseContext _context = new DatabaseContext())
            {
                decorativeColumnToFind = _context.DecorativeColumns.Where(d => (d.Grid.GridId == grid.GridId
                && d.UbicationPoint == decorativeColumn.UbicationPoint)).FirstOrDefault();
            }
            return !(decorativeColumnToFind == null);
        }

        public List<DecorativeColumn> GetList(Grid grid)
        {
            try
            {
                List<DecorativeColumn> decorativeColumnList = null;
                using (DatabaseContext _context = new DatabaseContext())
                {
                    decorativeColumnList = _context.DecorativeColumns
                        .Where(d => d.Grid.GridId == grid.GridId)
                        .ToList();
                }
                return decorativeColumnList;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public void Remove(Grid grid, DecorativeColumn decorativeColumn)
        {
            DecorativeColumn decorativeColumnToDelete = null;
            using (DatabaseContext _context = new DatabaseContext())
            {
                decorativeColumnToDelete = _context.DecorativeColumns
                    .Where(d =>
                    (d.Grid.GridId == grid.GridId && d.DecorativeColumnId == decorativeColumn.DecorativeColumnId))
                    .FirstOrDefault();

                _context.DecorativeColumns.Attach(decorativeColumnToDelete);
                _context.DecorativeColumns.Remove(decorativeColumnToDelete);
                _context.SaveChanges();
            }
        }
    }
}
