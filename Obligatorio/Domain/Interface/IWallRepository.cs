using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Interface
{
    public interface IWallRepository
    {
        void AddWall(Grid grid, Wall wall);
        List<Wall> GetAllWalls(Grid grid);
    }
}
