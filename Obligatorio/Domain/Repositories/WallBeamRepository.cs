using Domain.Entities;
using Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Repositories
{
    public class WallBeamRepository : IWallBeamRepository
    {
        public void Add(Grid grid, WallBeam wallBeam)
        {
            using (DatabaseContext _context = new Domain.DatabaseContext())
            {
                try
                {
                    _context.Grids.Attach(grid);
                    wallBeam.Grid = grid;
                    _context.WallBeams.Add(wallBeam);
                    _context.SaveChanges();
                }
                catch (Exception e)
                {

                }
            }
        }

        public int Count(Grid grid)
        {
            return this.GetList(grid).Count;
        }

        public WallBeam Get(Grid grid, WallBeam wallBeam)
        {
            WallBeam wallBeamToFind = null;
            using (DatabaseContext _context = new DatabaseContext())
            {
                wallBeamToFind = _context.WallBeams
                    .Where(w =>
                    (w.Grid.GridId == grid.GridId && w.UbicationPoint == wallBeam.UbicationPoint))
                    .FirstOrDefault();
            }
            return wallBeamToFind;
        }

        public List<WallBeam> GetList(Grid grid)
        {
            try
            {
                List<WallBeam> wallBeamList = null;
                using (DatabaseContext _context = new DatabaseContext())
                {
                    wallBeamList = _context.WallBeams
                        .Where(w => w.Grid.GridId == grid.GridId)
                        .ToList();
                }
                return wallBeamList;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public bool Exist(Grid grid, WallBeam wallBeam)
        {
            WallBeam wallBeamToFind = null;
            using (DatabaseContext _context = new DatabaseContext())
            {
                wallBeamToFind = _context.WallBeams
                    .Where(w =>
                    (w.Grid.GridId == grid.GridId && w.UbicationPoint == wallBeam.UbicationPoint))
                    .FirstOrDefault();
            }
            return !(wallBeamToFind == null);
        }

        public void Remove(Grid grid, WallBeam wallBeam)
        {
            WallBeam wallBeamToDelete = null;
            using (DatabaseContext _context = new DatabaseContext())
            {
                wallBeamToDelete = _context.WallBeams
                    .Where(w =>
                    (w.Grid.GridId == grid.GridId && w.WallBeamId == wallBeam.WallBeamId))
                    .FirstOrDefault();

                _context.WallBeams.Attach(wallBeamToDelete);
                _context.WallBeams.Remove(wallBeamToDelete);
                _context.SaveChanges();
            }
        }
    }
}
