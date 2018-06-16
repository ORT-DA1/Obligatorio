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
            using (DatabaseContext _context = new DatabaseContext())
            {
                _context.Grids.Add(grid);
                _context.SaveChanges();
            }
        }
        public void ModifyGrid(Grid gridToModify, Grid modifiedGrid)
        {
            //TODO
            //Tiene modify?!?!
        }
        public void DeleteGrid(Grid grid)
        {
            using (DatabaseContext _context = new DatabaseContext())
            {
                _context.Grids.Attach(grid);
                _context.Grids.Remove(grid);
            }
        }
        public Grid GetGrid(Grid grid)
        { 
            using (DatabaseContext _context = new DatabaseContext())
            {
                return _context.Grids.Where(g => g.GridName ==  grid.GridName).FirstOrDefault();
            }
        }
        public List<Grid> GetAllGrids()
        {
            using(DatabaseContext _context = new DatabaseContext())
            {
                return _context.Grids.ToList();
            }
        }
    }
}
