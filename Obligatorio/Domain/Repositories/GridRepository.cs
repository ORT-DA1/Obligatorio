using System.Collections.Generic;
using System.Linq;
using Domain.Entities;
using Domain.Interface;

namespace Domain.Repositories
{
    public class GridRepository: IGridRepository
    {
        public void AddGrid(Grid grid)
        {
            //_context.Grids.Add(grid);
        }
        public void ModifyGrid(Grid gridToModify, Grid modifiedGrid)
        {
            //TODO
        }
        public void DeleteGrid(Grid grid)
        {
            //_context.Grids.Remove(grid);
        }
        /*public Grid GetGrid(Grid grid)
        {
            return _context.Grids.Find();
        }*/
        /*public List<Grid> GetAllGrids()
        {
            return _context.Grids.ToList();
        }*/
    }
}
