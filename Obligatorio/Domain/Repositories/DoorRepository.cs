using Domain.Entities;
using Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public class DoorRepository : IDoorRepository
    {
        public void AddDoor(Grid grid, Door door)
        {
            using (DatabaseContext _context = new Domain.DatabaseContext())
            {
                _context.Doors.Add(door);
                _context.SaveChanges();
            }
        }
        public List<Door> GetAllDoors(Grid grid)
        {
            using (DatabaseContext _context = new Domain.DatabaseContext())
            {
                return _context.DecorativeColumns.Where(d => d.GridId == grid.GridId).ToList();
            }
        }
    }
}
