using Domain.Entities;
using Domain.Interface;
using System.Collections.Generic;

namespace Domain.Repositories
{
    public class WallBeamRepository : IWallBeamRepository
    {
        public void AddWallBeam(Grid grid, WallBeam wallBeam)
        {
            using (DatabaseContext _context = new Domain.DatabaseContext())
            {
                _context.WallBeams.Add(wallBeam);
                _context.SaveChanges();
            }

        }

        public List<WallBeam> GetAllWallBeams(Grid grid)
        {
            using (DatabaseContext _context = new Domain.DatabaseContext())
            {
                return _context.WallBeams.Where(d => d.GridId == grid.GridId).ToList();
            }
        }
    }
}
