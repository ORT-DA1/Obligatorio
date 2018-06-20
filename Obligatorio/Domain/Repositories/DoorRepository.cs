using Domain.Entities;
using Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Repositories
{
    public class DoorRepository : IDoorRepository
    {
        public DatabaseContext _context;
        public DoorRepository(GridRepository gridRepository)
        {
            this._context = gridRepository._context;
        }
        public void Add(Grid grid, Door door)
        {
            _context.Grids.Attach(grid);
            door.Grid = grid;
            _context.Doors.Add(door);
            _context.SaveChanges();
        }

        public int Count(Grid grid)
        {
            return this.GetList(grid).Count;
        }

        public bool Exist(Grid grid, Door door)
        {
            Door doorToFind = null;
            doorToFind = _context.Doors
                .Where(d =>
                (d.Grid.GridId == grid.GridId && d.StartPoint == door.StartPoint))
                .FirstOrDefault();
            return !(doorToFind == null);
        }

        public List<Door> GetList(Grid grid)
        {
            try
            {
                List<Door> doorList = null;
                doorList = _context.Doors
                    .Where(d => d.Grid.GridId == grid.GridId)
                    .ToList();

                return doorList;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public void Remove(Grid grid, Door door)
        {
            Door doorToDelete = null;
            doorToDelete = _context.Doors
                .Where(d =>
                (d.Grid.GridId == grid.GridId && d.DoorId == door.DoorId))
                .FirstOrDefault();
            
            _context.Doors.Remove(doorToDelete);
            _context.SaveChanges();

        }
    }
}
