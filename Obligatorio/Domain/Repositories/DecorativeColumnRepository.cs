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
                _context.DecorativeColumns.Add(decorativeColumn);
                _context.SaveChanges();
            }
        }

        public int Count(Grid grid)
        {
            throw new NotImplementedException();
        }
        
        public bool Exist(Grid grid, DecorativeColumn decorativeColumn)
        {
            DecorativeColumn decorativeColumnToFind = null;
            using (DatabaseContext _context = new DatabaseContext())
            {
                decorativeColumnToFind = _context.DecorativeColumns.Where(d => (d.GridId == grid.GridId
                && d.UbicationPoint == decorativeColumn.UbicationPoint)).FirstOrDefault();
            }
            return !(decorativeColumnToFind == null);
        }

        public List<DecorativeColumn> GetList(Grid grid)
        {
            using (DatabaseContext _context = new Domain.DatabaseContext())
            {
                return _context.DecorativeColumns.Where(d => d.GridId == grid.GridId).ToList();
            }
        }

        public void Remove(Grid grid, DecorativeColumn decorativeColumn)
        {
            using (DatabaseContext _context = new DatabaseContext())
            {
                _context.DecorativeColumns.Attach(decorativeColumn);
                _context.DecorativeColumns.Remove(decorativeColumn);
                _context.SaveChanges();
            }
        }
    }
}
