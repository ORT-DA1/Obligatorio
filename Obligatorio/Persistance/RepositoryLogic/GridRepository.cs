using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistance.Interface;
using Domain.Entities;

namespace Persistance.RepositoryLogic
{
    public class GridRepository: IGridRepository
    {
        private ContextDB _context;

        public GridRepository(ContextDB context)
        {
            this._context = context;
        }

        public void AddGrid(Grid grid)
        {
            _context.Grids.Add(grid);
        }
        public void ModifyGrid(Grid gridToModify, Grid modifiedGrid)
        {
            //TODO
        }
        public void DeleteGrid(Grid grid)
        {
            _context.Grids.Remove(grid);
        }
        public Grid GetGrid(Grid grid)
        {
            return _context.Grids.Find();
        }
        public List<Grid> GetAllGrids()
        {
            return _context.Grids.ToList();
        }
    }
}
