using Domain.Entities;
using Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public class DecorativeColumnRepository : IDecorativeColumnRepository
    {
        public void AddDecorativeColumn(Grid grid, DecorativeColumn decorativeColumn)
        {
            using (DatabaseContext _context = new Domain.DatabaseContext())
            {
                _context.DecorativeColumns.Add(decorativeColumn);
                _context.SaveChanges();
            }
        }

        public List<DecorativeColumn> GetAllDecorativeColumns(Grid grid)
        {
            using (DatabaseContext _context = new Domain.DatabaseContext())
            {
                return _context.DecorativeColumns.Where(d => d.GridId == grid.GridId).ToList();
            }
        }
    }
}
