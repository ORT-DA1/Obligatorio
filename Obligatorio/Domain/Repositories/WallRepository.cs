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

        public List<Wall> GetList(Grid grid)
        {
            List<Wall> wallList = null;
            using (DatabaseContext _context = new DatabaseContext())
            {
                wallList = _context.Walls
                    .Where(w => 
                    w.GridId == grid.GridId)
                    .ToList();
            }
            return wallList;
        }

        public void Remove(Grid grid, Wall wall)
        {
            Wall wallToDelete = null;
            using (DatabaseContext _context = new DatabaseContext())
            {
                wallToDelete = _context.Walls
                    .Where(d =>
                    (d.GridId == grid.GridId && d.WallId == wall.WallId))
                    .FirstOrDefault();

                _context.Walls.Attach(wallToDelete);
                _context.Walls.Remove(wallToDelete);
                _context.SaveChanges();
            }
        }
    }
}
