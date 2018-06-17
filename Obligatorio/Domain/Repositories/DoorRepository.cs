using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public class DoorRepository : IDoorRepository
    {
        public void AddDoor(Door door)
        {
            using (DatabaseContext _context = new Domain.DatabaseContext())
            {
                _context.Doors.Add(door);
                _context.SaveChanges();
            }
        }
    }
}
