using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Interface
{
    public interface IDoorRepository
    {
        void AddDoor(Grid grid, Door door);
        List<Door> GetAllDoors(Grid grid);
    }

}
