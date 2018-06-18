using Domain.Entities;
using Domain.Interface;
using System.Collections.Generic;
using System;

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

        public void Remove(Grid grid, WallBeam wallBeam)
        {
            throw new NotImplementedException();
        }
    }
}
