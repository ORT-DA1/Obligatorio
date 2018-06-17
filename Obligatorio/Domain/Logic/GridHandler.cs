using Domain.Data;
using Domain.Entities;
using Domain.Exceptions;
using System.Collections.Generic;
using System.Linq;
using Domain.Repositories;
using Domain.Interface;

namespace Domain.Logic
{
    public class GridHandler
    {
        private ClientHandler clientHandler;
        public IGridRepository gridRepository;

        public GridHandler()
        {
            this.clientHandler = new ClientHandler();
            this.gridRepository = new GridRepository();
        }
        public Grid Get(Grid grid)
        {
            NotExist(grid);
            return this.gridRepository.GetGrid(grid);
        }
        public void Add(Grid grid)
        {
            Validate(grid);
            this.gridRepository.AddGrid(grid); 
        }

        public void AddWall(Grid grid, Wall wall)
        {

            this.gridRepository.AddWall(grid,wall);
        }

        public void AddWallBeam(Grid grid, WallBeam wallBeam)
        {
            this.gridRepository.AddWallBeam(grid, wallBeam);
        }

        public void AddWindow(Grid grid, Window window)
        {
            this.gridRepository.AddWindow(grid, window);
        }

        public void AddDoor(Grid grid, Door door)
        {
            this.gridRepository.AddDoor(grid, door);
        }

        public void AddDecorativeColumn(Grid grid, DecorativeColumn decorativeColumn)
        {
            this.gridRepository.AddDecorativeColumn(grid, decorativeColumn);
        }

        private void Validate(Grid grid)
        {
            DataValidation.ValidateGridName(grid.GridName);
            clientHandler.NotExist(grid.Client);
            DataValidation.ValidateHeight(grid.Height);
            DataValidation.ValidateWidth(grid.Width);
        }
        public void Delete(Grid grid)
        {
            NotExist(grid);
            this.gridRepository.DeleteGrid(grid);
        }
        public void NotExist(Grid grid)
        {
            //if (this.gridRepository.)
            //{
            //    throw new ExceptionController(ExceptionMessage.WALL_NOT_EXIST);
            //}
        }
        public List<Grid> GetList()
        {
            List<Grid> gridList = this.gridRepository.GetAllGrids();
            IsNotEmpty(gridList);
            return gridList;
        }
        public List<Grid> GetClientGrids(Client client)
        {
            List<Grid> gridList = new List<Grid>();
            foreach(Grid grid in this.gridRepository.GetAllGrids())
            {
                if (ClientGrid(client, grid)){
                    gridList.Add(grid);
                }
            }
            IsNotEmpty(gridList);
            return gridList;
        }
        private bool ClientGrid(Client client, Grid grid)
        {
            if (grid.Client.Equals(client))
                return true;
            else
                return false;
        }
        private void IsNotEmpty(List<Grid> gridList)
        {
            if (!gridList.Any())
            {
                throw new ExceptionController(ExceptionMessage.EMPTY_GRID_LIST);
            }
        }
    }
}
