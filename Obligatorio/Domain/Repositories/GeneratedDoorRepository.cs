using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Repositories
{
    public class GeneratedDoorRepository
    {

        public GeneratedDoorRepository() { }

        public void Add(Architect architect, GeneratedDoor generatedDoor, PriceAndCost priceAndCost)
        {
            using (DatabaseContext _context = new DatabaseContext())
            {
                PriceAndCost priceAndCostToFind = _context.PricesAndCosts
                .Where(p => p.PriceAndCostId == 3)
                .FirstOrDefault();

                generatedDoor.PriceAndCost = priceAndCostToFind;
                _context.Architects.Attach(architect);
                generatedDoor.Architect = architect;
                _context.GeneratedDoors.Add(generatedDoor);
                _context.SaveChanges();
            }
        }

        public GeneratedDoor GetGeneratedDoor(GeneratedDoor generatedDoor)
        {
            using (DatabaseContext _context = new DatabaseContext())
            {
                return _context.GeneratedDoors
                    .Where(d => d.GeneratedDoorId == generatedDoor.GeneratedDoorId)
                    .FirstOrDefault();
            }
        }

        public List<GeneratedDoor> GetList()
        {
            using (DatabaseContext _context = new DatabaseContext())
            {
                List<GeneratedDoor> generatedDoorList = null;
                generatedDoorList = _context.GeneratedDoors
                    .ToList();
                return generatedDoorList;
            }
        }
    }
}
