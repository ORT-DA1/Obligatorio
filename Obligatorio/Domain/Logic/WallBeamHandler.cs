using System.Collections.Generic;
using Domain.Entities;
using Domain.Interface;

namespace Domain.Logic
{
    public class WallBeamHandler : IElementHandler<WallBeam>
    {
        private IWallBeamRepository wallBeamRepository;
        
        public void Add(Grid grid, WallBeam wallBeam)
        {
            this.wallBeamRepository.AddWallBeam(grid, wallBeam);
        }

        public List<WallBeam> GetList(Grid grid)
        {
            List<WallBeam> wallBeamList = wallBeamRepository.GetAllWallBeams(grid);
            //
            return wallBeamList;
        }
    }
}
