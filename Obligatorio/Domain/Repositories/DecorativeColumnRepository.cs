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
        public void AddDecorativeColumn(DecorativeColumn decorativeColumn)
        {
            using (DatabaseContext _context = new Domain.DatabaseContext())
            {
                _context.DecorativeColumns.Add(decorativeColumn);
                _context.SaveChanges();
            }
        }
    }
}
