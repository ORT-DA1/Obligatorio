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
        public List<Grid> GetClientNotSignedGrids(Client client)
        {
            List<Grid> gridList = new List<Grid>();
            foreach(Grid grid in this.gridRepository.GetAllGrids())
            {
                if (ClientGrid(client, grid) && !IsGridSigned(grid)){
                    gridList.Add(grid);
                }
            }
            return gridList;
        }
        private bool ClientGrid(Client client, Grid grid)
        {
            return grid.Client.Equals(client) ? true : false;
        }
        private void IsNotEmpty(List<Grid> gridList)
        {
            if (!gridList.Any())
            {
                throw new ExceptionController(ExceptionMessage.EMPTY_GRID_LIST);
            }
        }
        public List<Signature> GetGridSignatures(Grid grid)
        {
            List<Signature> signatureList = this.gridRepository.GetSignatures(grid);

            return signatureList != null ? signatureList : null;
        }
        public void SaveSignature(Grid grid, Signature signature)
        {
            this.gridRepository.SaveSignature(grid, signature);
        }
        public List<Grid> GetClientSignedGrids(Client client)
        {
            List<Grid> gridList = new List<Grid>();
            foreach (Grid grid in this.gridRepository.GetAllGrids())
            {
                if (ClientGrid(client, grid) && IsGridSigned(grid))
                {
                    gridList.Add(grid);
                }
            }
            return gridList;
        }
        private bool IsGridSigned(Grid grid)
        {
            return grid.Signatures.Any() ? true : false;
        }
    }
}
