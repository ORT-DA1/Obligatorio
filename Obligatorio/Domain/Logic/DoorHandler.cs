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
            this.doorRepository.Add(grid, door);
        }

        public List<Door> GetList(Grid grid)
        {
            List<Door> doorList = doorRepository.GetList(grid);
            return doorList;
        }

        public void Remove(Grid grid, Door door)
        {
            doorRepository.Remove(grid, door);
        }

        public bool Exist(Grid grid, Door door)
        {
            return doorRepository.Exist(door);
        }

        public int Count(Grid grid)
        {
            return doorRepository.Count(grid);
        }
    }
}
