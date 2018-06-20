using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Entities;
using Domain.Interface;
using System.Data.Entity;

namespace Domain.Repositories
{
    public class GridRepository : IGridRepository
    {
        public DatabaseContext _context { get; set; }
        public GridRepository()
        {
            _context = new DatabaseContext();
        }

        public void AddGrid(Grid grid)
        {
            _context.Grids.Add(grid);
            _context.SaveChanges();
        }

        public void ModifyGrid(Grid gridToModify, Grid modifiedGrid)
        {
            //TODO
            //Tiene modify?!?!
        }
        public void DeleteGrid(Grid grid)
        {
            _context.Grids.Attach(grid);
            _context.Grids.Remove(grid);
        }
        public Grid GetGrid(Grid grid)
        {
            return _context.Grids.Where(g => g.GridName == grid.GridName && grid.GridId == g.GridId).FirstOrDefault();

        }
        public List<Grid> GetAllGrids()
        {
            return _context.Grids.ToList();
        }

        public Grid ReadGrid(Grid grid)
        {
            Grid gridToReturn = null;
            gridToReturn = (from g in _context.Grids
                            where g.GridId == grid.GridId
                            select g).FirstOrDefault();
            //select g).Include("DecorativeColumns").FirstOrDefault();

            return gridToReturn;
        }


        public void AddWall(Grid grid, Wall wall)
        {
            var co = (from c in _context.Grids
                      where c.GridId == grid.GridId
                      select c).FirstOrDefault();
            co.Walls.Add(wall);
            _context.SaveChanges();
        }
        public void AddWallBeam(Grid grid, WallBeam wallBeam)
        {
            var co = (from c in _context.Grids
                      where c.GridId == grid.GridId
                      select c).FirstOrDefault();
            co.WallBeams.Add(wallBeam);
            _context.SaveChanges();
        }

        public void AddWindow(Grid grid, Window window)
        {
            var co = (from c in _context.Grids
                      where c.GridId == grid.GridId
                      select c).FirstOrDefault();
            co.Windows.Add(window);
            _context.SaveChanges();
        }

        public void AddDoor(Grid grid, Door door)
        {
            using (DatabaseContext _context = new DatabaseContext())
            {
                var co = (from c in _context.Grids
                          where c.GridId == grid.GridId
                          select c).FirstOrDefault();
                co.Doors.Add(door);
                _context.SaveChanges();
            }
        }

        public void AddDecorativeColumn(Grid grid, DecorativeColumn decorativeColumn)
        {
            using (DatabaseContext _context = new DatabaseContext())
            {
                var co = (from c in _context.Grids
                          where c.GridId == grid.GridId
                          select c).FirstOrDefault();
                co.DecorativeColumns.Add(decorativeColumn);
                _context.SaveChanges();
            }
        }
    }
}
