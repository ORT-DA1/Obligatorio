using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Interface
{
    public interface IWallBeamRepository
    {
        void AddWallBeam(Grid grid, WallBeam wallBeam);
        List<WallBeam> GetAllWallBeams(Grid grid);
    }
}
