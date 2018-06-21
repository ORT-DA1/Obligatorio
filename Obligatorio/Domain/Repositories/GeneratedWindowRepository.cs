using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Logic;

namespace Domain.Repositories
{
    public class GeneratedWindowRepository
    {
        WindowHandler windowHandler;
        public GeneratedWindowRepository() {
        }

        public List<GeneratedWindow> GetList()
        {
            using (DatabaseContext _context = new DatabaseContext())
            {
                List<GeneratedWindow> generatedWindowList = null;
                generatedWindowList = _context.GeneratedWindows
                    .ToList();
                return generatedWindowList;
            }
        }

        public GeneratedWindow GetGeneratedWindow(GeneratedWindow generatedWindow)
        {
            using (DatabaseContext _context = new DatabaseContext())
            {
                return _context.GeneratedWindows
                    .Where(d => d.GeneratedWindowId == generatedWindow.GeneratedWindowId)
                    .FirstOrDefault();
            }
        }

        public void Add(Architect architect, GeneratedWindow generatedWindow)
        {
            using (DatabaseContext _context = new DatabaseContext())
            {
                PriceAndCost priceAndCostToFind = _context.PricesAndCosts
                .Where(p => p.PriceAndCostId == 3)
                .FirstOrDefault();

                generatedWindow.PriceAndCost = priceAndCostToFind;
                _context.Architects.Attach(architect);
                generatedWindow.Architect = architect;
                _context.GeneratedWindows.Add(generatedWindow);
                _context.SaveChanges();
            }
        }
    }
}
