using Domain.Data;
using Domain.Entities;
using Domain.Exceptions;

namespace Domain.Logic
{
    public class GridHandler
    {
        private DataStorage storage;

        public GridHandler()
        {
            this.storage = DataStorage.GetStorageInstance();
        }

        public Grid Get(Client client)
        {
            return this.storage.GetGrid(client);
        }

        public void Add(Grid grid)
        {
            Validate(grid);
            this.storage.SaveGrid(grid);
        }

        private void Validate(Grid grid)
        {
            DataValidation.ValidateHeight(grid.Height);
            DataValidation.ValidateWidth(grid.Width);
        }

        public void Delete(Grid grid)
        {
            this.storage.DeleteGrid(grid);
        }
        
    }

}
