using Domain.Entities;
using Domain.Interface;
using System.Collections.Generic;
using System;
using System.Linq;

namespace Domain.Repositories
{
    public class WallBeamRepository : IWallBeamRepository
    {
        public void Add(Grid grid, WallBeam wallBeam)
        {
            using (DatabaseContext _context = new Domain.DatabaseContext())
            {
                _context.WallBeams.Add(wallBeam);
                _context.SaveChanges();
            }

        }

        public int Count(Grid grid)
        {
            throw new NotImplementedException();
        }

        public WallBeam Get(Grid grid, Point startUbicationPoint)
        {
            throw new NotImplementedException();
        }

        public List<WallBeam> GetList(Grid grid)
        {
            using (DatabaseContext _context = new Domain.DatabaseContext())
            {
                return _context.WallBeams.Where(d => d.GridId == grid.GridId).ToList();
            }
        }

        public bool Exist(Grid grid, WallBeam wallBeam)
        {
            WallBeam wallBeamToFind = null;
            using (DatabaseContext _context = new DatabaseContext())
            {
                wallBeamToFind = _context.WallBeams.Where(w => (w.GridId == grid.GridId
                && w.UbicationPoint == wallBeam.UbicationPoint)).FirstOrDefault();
            }
            return !(wallBeamToFind == null);
        }

        public void Remove(Grid grid, WallBeam wallBeam)
        {
            using (DatabaseContext _context = new DatabaseContext())
            {
                _context.WallBeams.Attach(wallBeam);
                _context.WallBeams.Remove(wallBeam);
                _context.SaveChanges();
            }
        }
    }
}
