using Domain.Entities;
using Domain.Interface;
using System.Collections.Generic;
using System.Linq;
using System;
using Domain.Logic;
using System.Data.Entity;

namespace Domain.Repositories
{
    public class WallRepository : IWallRepository
    {
        public DatabaseContext _context;
        
        public WallRepository(GridRepository gridRepository)
        {
            this._context = gridRepository._context;
        }
        public void Add(Grid grid, Wall wall)
        {
            _context.Grids.Attach(grid);
            wall.Grid = grid;
            _context.Walls.Add(wall);
            _context.SaveChanges();
        }

        public List<Wall> GetList(Grid grid)
        {
            List<Wall> wallList = null;
            wallList = _context.Walls
                .Where(w => w.Grid.GridId == grid.GridId)
                .Include("startUbicationPoint")
                .Include("endUbicationPoint")
                .ToList();
            return wallList;
        }

        public void Remove(Grid grid, Wall wall)
        {
            Wall wallToDelete = null;
            wallToDelete = _context.Walls
                .Where(d =>
                (d.Grid.GridId == grid.GridId && d.WallId == wall.WallId))
                .FirstOrDefault();

            _context.Walls.Remove(wallToDelete);
            _context.SaveChanges();
        }

        public List<Point> GetWallPath(Wall wall)
        {
            try
            {
                List<Point> pathList = null;
                using (DatabaseContext _context = new DatabaseContext())
                {
                    /*_context.Walls.Attach(wall);
                    pathList = _context.Points
                        .Where(p => p.Wall.WallId == wall.WallId)
                        .ToList();*/
                }
                return pathList;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
