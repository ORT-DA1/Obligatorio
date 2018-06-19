using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Interface
{
    public interface IWallRepository
    {
        void Add(Grid grid, Wall wall);
        List<Wall> GetList(Grid grid);
        void Remove(Grid grid, Wall intersectWall);
    }
}
