using Domain.Entities;
using Domain.Interface;

namespace Domain.Repositories
{
    public class WallBeamRepository : IWallBeamRepository
    {
        public void AddWallBeam(WallBeam wallBeam)
        {
            using (DatabaseContext _context = new Domain.DatabaseContext())
            {
                _context.WallBeams.Add(wallBeam);
                _context.SaveChanges();
            }

        }
    }
}
