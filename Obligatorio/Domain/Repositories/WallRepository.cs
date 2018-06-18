using Domain.Entities;
using Domain.Interface;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Domain.Repositories
{
    public class WallRepository : IWallRepository
    {
        public void Add(Grid grid, Wall wall)
        {
            using (DatabaseContext _context = new Domain.DatabaseContext())
            {
                _context.Walls.Add(wall);
                _context.SaveChanges();
            }
        }
        public List<Wall> GetAllWalls(Grid grid)
        {
            using (DatabaseContext _context = new Domain.DatabaseContext())
            {
                return _context.Walls.Where(d => d.GridId == grid.GridId).ToList();
            }
        }

        public List<Wall> GetList(Grid grid)
        {
            throw new NotImplementedException();
        }

        public void Remove(Grid grid, Wall intersectWall)
        {
            throw new NotImplementedException();
        }
    }
}
