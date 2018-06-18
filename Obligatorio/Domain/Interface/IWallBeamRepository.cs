using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Interface
{
    public interface IWallBeamRepository
    {
        void Add(Grid grid, WallBeam wallBeam);
        int Count(Grid grid);
        void Remove(Grid grid, WallBeam wallBeam);
        WallBeam Get(Grid grid, Point startUbicationPoint);
        List<WallBeam> GetList(Grid grid);
    }
}
