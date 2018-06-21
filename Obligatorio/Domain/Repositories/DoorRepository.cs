using Domain.Entities;
using Domain.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
        public void Add(Grid grid, Door door, PriceAndCost priceAndCost)
        {
            PriceAndCost priceCost = _context.PricesAndCosts
                .Where(w => w.PriceAndCostId == priceAndCost.PriceAndCostId)
                .FirstOrDefault();
            door.PriceAndCost = priceCost;
            _context.Grids.Attach(grid);
            door.Grid = grid;
            _context.Doors.Add(door);
            _context.SaveChanges();
        }

        public int Count(Grid grid)
        {
            return this.GetList(grid).Count;
        }

        public bool Exist(Grid grid, Point ubicationPoint)
        {
            Door doorToFind = null;
            doorToFind = _context.Doors
                .Where(w => (w.Grid.GridId == grid.GridId
                && w.StartPoint.X == ubicationPoint.X)
                && w.StartPoint.Y == ubicationPoint.Y)
                .FirstOrDefault();

            return !(doorToFind == null);
        }

        public Door GetDoor(Door door)
        {
            return _context.Doors
                .Where(d => d.DoorId == door.DoorId)
                .Include("StartPoint")
                .Include("EndPoint")
                .FirstOrDefault();
        }

        public Door GetFirst()
        {
            return _context.Doors.Where(d => d.DoorId == 1).FirstOrDefault();
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

        public List<string> GetNameList()
        {
            List<string> listName = new List<string>();
            var names = from door in _context.Doors
                        select new { door.Name };

            foreach (var name in names)
            {
                if (!listName.Contains(name.ToString()))
                {
                    listName.Add(name.ToString());
                }
            }
            return listName;
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
