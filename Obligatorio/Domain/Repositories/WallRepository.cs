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
            _context.Grids.Attach(grid);
            _context.Walls.Attach(wall);
            wall.Grid = null;
            _context.Walls.Remove(wall);
            _context.SaveChanges();
        }

        public List<Point> GetWallPath(Wall wall)
        {
            try{
                return CalculatePath(wall);
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public List<Point> CalculatePath(Wall wall)
        {
            int max = getDistance(wall);
            List<Point> Path = new List<Point>();
            if (isHorizontalWall(wall))
            {
                for (int i = 0; i <= max;)
                {
                    Point point = new Point(wall.startUbicationPoint.X + i, wall.startUbicationPoint.Y);
                    Path.Add(point);
                    i += Grid.PixelConvertor;
                }
            }
            else
            {
                for (int i = 0; i <= max;)
                {
                    Point point = new Point(wall.startUbicationPoint.X, wall.startUbicationPoint.Y + i);
                    Path.Add(point);
                    i += Grid.PixelConvertor;
                }
            }
            return Path;
        }

        public int getDistance(Wall wall)
        {
            if (isHorizontalWall(wall))
                return Math.Abs((wall.startUbicationPoint.X) - (wall.endUbicationPoint.X));
            else
                return Math.Abs((wall.startUbicationPoint.Y) - (wall.endUbicationPoint.Y));
        }

        public bool isHorizontalWall(Wall wall)
        {
            return wall.startUbicationPoint.Y == wall.endUbicationPoint.Y;
        }

        public Wall ObtainWallInPoint(Grid grid, Point ubicationPoint)
        {
            _context.Points.Attach(ubicationPoint);

            return _context.Walls
                .Where(w =>
                (w.Grid.GridId == grid.GridId
                && w.Path.Any(p => p.X == ubicationPoint.X
                && p.Y == ubicationPoint.Y)))
                .FirstOrDefault();
        }
        
    }
}
