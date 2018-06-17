using Domain.Entities;
using Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public class WallRepository : IWallRepository
    {
        public void AddWall(Wall wall)
        {
            using (DatabaseContext _context = new Domain.DatabaseContext())
            {
                _context.Walls.Add(wall);
                _context.SaveChanges();
            }
        }
    }
}
