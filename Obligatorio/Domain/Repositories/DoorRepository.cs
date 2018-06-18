using Domain.Entities;
using Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Repositories
{
    public class DoorRepository : IDoorRepository
    {
        public void Add(Grid grid, Door door)
        {
            using (DatabaseContext _context = new Domain.DatabaseContext())
            {
                _context.Doors.Add(door);
                _context.SaveChanges();
            }
        }

        public int Count(Grid grid)
        {
            throw new NotImplementedException();
        }

        public bool Exist(Grid grid, Door door)
        {
            Door doorToFind = null;
            using (DatabaseContext _context = new DatabaseContext())
            {
                doorToFind = _context.Doors.Where(d => (d.GridId == grid.GridId
                && d.StartPoint == door.StartPoint)).FirstOrDefault();
            }
            return !(doorToFind == null);
        }

        public List<Door> GetList(Grid grid)
        {
            using (DatabaseContext _context = new Domain.DatabaseContext())
            {
                return _context.DecorativeColumns.Where(d => d.GridId == grid.GridId).ToList();
            }
        }

        public void Remove(Grid grid, Door door)
        {
            using (DatabaseContext _context = new DatabaseContext())
            {
                _context.Doors.Attach(door);
                _context.Doors.Remove(door);
                _context.SaveChanges();
            }
        }
    }
}
