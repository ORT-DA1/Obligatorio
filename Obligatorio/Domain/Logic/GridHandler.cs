using Domain.Data;
using Domain.Entities;
using Domain.Exceptions;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Logic
{
    public class GridHandler
    {
        private DataStorage storage;
        private ClientHandler clientHandler;

        public GridHandler()
        {
            this.storage = DataStorage.GetStorageInstance();
            this.clientHandler = new ClientHandler();
        }

        public Grid Get(Client client)
        {
            clientHandler.NotExist(client);
            return this.storage.GetGrid(client);
        }

        public void Add(Grid grid)
        {
            Validate(grid);
            this.storage.SaveGrid(grid); 
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
            this.storage.DeleteGrid(grid);
        }
        
        public void NotExist(Grid grid)
        {
            if (!this.storage.Grids.Contains(grid))
            {
                throw new ExceptionController(ExceptionMessage.GRID_INVALID_HEIGHT_ABOVE); // cambiar exception
            }
        }
        public List<Grid> GetList()
        {
            List<Grid> gridList = storage.Grids;
            IsNotEmpty(gridList);
            return gridList;
        }
        private void IsNotEmpty(List<Grid> gridList)
        {
            if (!gridList.Any())
            {
                //throw new ExceptionController(ExceptionMessage.EMPTY_GRID_LIST);
            }
        }

    }

}
