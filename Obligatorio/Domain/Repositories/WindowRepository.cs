using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public class WindowRepository : IWindowRepository
    {
        public void AddWindow(Window window)
        {
            using (DatabaseContext _context = new Domain.DatabaseContext())
            {
                _context.Windows.Add(window);
                _context.SaveChanges();
            }
        }

    }
}
