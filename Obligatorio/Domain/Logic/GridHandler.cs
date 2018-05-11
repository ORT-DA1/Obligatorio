using Domain.Data;
using Domain.Entities;
using System;

namespace Domain.Logic
{
    public class GridHandler
    {
        private DataStorage storage;

        public GridHandler()
        {
            this.storage = DataStorage.GetStorageInstance();
        }
        public void Add(Grid grid)
        {
            Exist(grid);
            this.storage.SaveGrid(grid);
        }
        public void Delete(Grid grid)
        {
            this.storage.DeleteGrid(grid);

        }
        public void Exist(Grid grid)
        {
            if (storage.Grids.Contains(grid))
            {
                throw new Exception();
            }
        }
        
        public Grid Get(Client client)
        {
            return this.storage.GetGrid(client);
        }
        
    }

}
