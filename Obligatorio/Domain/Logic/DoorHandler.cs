using System;
using System.Collections.Generic;
using Domain.Entities;
using Domain.Interface;

namespace Domain.Logic
{
    public class DoorHandler : IElementHandler<Door>
    {
        private IDoorRepository doorRepository;
        public void Add(Grid grid, Door door)
        {
            this.doorRepository.AddDoor(grid, door);
        }

        public List<Door> GetList(Grid grid)
        {
            List<Door> doorList = doorRepository.GetAllDoors(grid);
            //
            return doorList;
        }
    }
}
