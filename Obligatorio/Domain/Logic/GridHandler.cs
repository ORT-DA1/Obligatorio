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
        public IGridRepository gridRepository;
        public DatabaseContext _context;
        
        public GridHandler()
        {
            this.gridRepository = new GridRepository();
        }
        public Grid Get(Grid grid)
        {
            Exist(grid);
            return this.gridRepository.GetGrid(grid);
        }
        public void Add(Grid grid, Client client)
        {
            Validate(grid);
            this.gridRepository.AddGrid(grid, client); 
        }

        private void Validate(Grid grid)
        {
            DataValidation.ValidateGridName(grid.GridName);
            DataValidation.ValidateHeight(grid.Height);
            DataValidation.ValidateWidth(grid.Width);
        }
        public void Delete(Grid grid)
        {
            this.gridRepository.DeleteGrid(grid);
        }
        public void Exist(Grid grid)
        {
            if (this.gridRepository.Exist(grid))
            {
                throw new ExceptionController(ExceptionMessage.GRID_ALREADY_EXIST_NAME);
            }
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
