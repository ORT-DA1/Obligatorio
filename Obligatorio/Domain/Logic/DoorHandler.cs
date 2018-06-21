using System;
using System.Collections.Generic;
using Domain.Entities;
using Domain.Interface;
using Domain.Repositories;
using Domain.Exceptions;

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

        public void Add(Grid grid, Door door, PriceAndCost priceAndCost)
        {
            isValid(door);
            this.doorRepository.Add(grid, door, priceAndCost);
        }

        private void isValid(Door door)
        {
            if (NotDefault(door))
            {
                NotExist(door);
                validSize(door);
            }
        }

        private void validSize(Door door)
        {
            if (door.Height > 2.00f || door.Width > 3.00f)
            {
                throw new ExceptionController(ExceptionMessage.DOOR_INVALID_SIZE);
            }
        }

        private void NotExist(Door door)
        {
            List<String> doorNames = doorRepository.GetNameList();
            if (doorNames.Contains(door.Name))
            {
                throw new ExceptionController(ExceptionMessage.WINDOW_NAME_ALREADY_EXIST);
            }
        }

        private bool NotDefault(Door door)
        {
            return door.Name != "default";
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
            return doorRepository.Exist(grid, door.StartPoint);
        }

        public int Count(Grid grid)
        {
            return doorRepository.Count(grid);
        }

        public Door GetFirst()
        {
            return doorRepository.GetFirst();
        }

        public Door GetDoor(Door door)
        {
            return doorRepository.GetDoor(door);
        }
    }
}
