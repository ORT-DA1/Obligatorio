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
            return this.GetList(grid).Count;
        }

        public bool Exist(Grid grid, Door door)
        {
            Door doorToFind = null;
            using (DatabaseContext _context = new DatabaseContext())
            {
                doorToFind = _context.Doors
                    .Where(d => 
                    (d.GridId == grid.GridId && d.StartPoint == door.StartPoint))
                    .FirstOrDefault();
            }
            return !(doorToFind == null);
        }

        public List<Door> GetList(Grid grid)
        {
            List<Door> doorList = null;
            using (DatabaseContext _context = new DatabaseContext())
            {
                doorList = _context.Doors
                    .Where(d =>
                    d.GridId == grid.GridId)
                    .ToList();
            }
            return doorList;
        }

        public void Remove(Grid grid, Door door)
        {
            Door doorToDelete = null;
            using (DatabaseContext _context = new DatabaseContext())
            {
                doorToDelete = _context.Doors
                    .Where(d =>
                    (d.GridId == grid.GridId && d.DoorId == door.DoorId))
                    .FirstOrDefault();

                _context.Doors.Attach(doorToDelete);
                _context.Doors.Remove(doorToDelete);
                _context.SaveChanges();
            }
        }
    }
}
