using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Interface
{
    public interface IWallBeamRepository
    {
        void Add(Grid grid, WallBeam wallBeam, PriceAndCost priceAndCost);
        int Count(Grid grid);
        void Remove(Grid grid, WallBeam wallBeam);
        List<WallBeam> GetList(Grid grid);
        WallBeam Get(Grid grid, Point point);
        WallBeam GetFirst();
    }
}
