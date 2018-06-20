using System;
using System.Collections.Generic;
using Domain.Entities;
using Domain.Interface;
using Domain.Repositories;

namespace Domain.Logic
{
    public class DoorHandler : IElementHandler<Door>
    {

        private GridHandler gridHandler;
        private IDoorRepository doorRepository;

        public DoorHandler(GridRepository gridRepository)
        {
            this.gridHandler = new GridHandler();
            this.doorRepository = new DoorRepository(gridRepository);
        }

        public void Add(Grid grid, Door door)
        {
            this.doorRepository.Add(grid, door);
        }

        public List<Door> GetList(Grid grid)
        {
            return doorRepository.GetList(grid);
        }

        public void Remove(Grid grid, Door door)
        {
            doorRepository.Remove(grid, door);
        }

        public bool Exist(Grid grid, Door door)
        {
            return doorRepository.Exist(grid, door);
        }

        public int Count(Grid grid)
        {
            return doorRepository.Count(grid);
        }
    }
}
