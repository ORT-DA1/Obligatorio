using Domain.Entities;
using Domain.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Domain.Repositories
{
    public class DecorativeColumnRepository : IDecorativeColumnRepository
    {
        public DatabaseContext _context;
        public DecorativeColumnRepository(GridRepository gridRepository)
        {
            this._context = gridRepository._context;
        }
        public void Add(Grid grid, DecorativeColumn decorativeColumn, PriceAndCost priceAndCost)
        {
            PriceAndCost priceCost = _context.PricesAndCosts
                .Where(w => w.PriceAndCostId == priceAndCost.PriceAndCostId)
                .FirstOrDefault();
            decorativeColumn.PriceAndCost = priceCost;
            _context.Grids.Attach(grid);
            decorativeColumn.Grid = grid;
            _context.DecorativeColumns.Add(decorativeColumn);
            _context.SaveChanges();
        }

        public int Count(Grid grid)
        {
            return this.GetList(grid).Count;
        }

        public bool Exist(Grid grid, Point ubicationPoint)
        {
            DecorativeColumn decorativeColumnToFind = null;
            decorativeColumnToFind = _context.DecorativeColumns
                .Where(w => (w.Grid.GridId == grid.GridId
                && w.UbicationPoint.X == ubicationPoint.X)
                && w.UbicationPoint.Y == ubicationPoint.Y)
                .FirstOrDefault();

            return !(decorativeColumnToFind == null);
        }

        public DecorativeColumn GetFirst()
        {
            return _context.DecorativeColumns.Where(d => d.DecorativeColumnId == 1).FirstOrDefault();
        }

        public List<DecorativeColumn> GetList(Grid grid)
        {
            try
            {
                List<DecorativeColumn> decorativeColumnList = null;
                decorativeColumnList = _context.DecorativeColumns
                    .Where(d => d.Grid.GridId == grid.GridId)
                    .Include("ubicationPoint")
                    .ToList();

                return decorativeColumnList;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public void Remove(Grid grid, DecorativeColumn decorativeColumn)
        {
            DecorativeColumn decorativeColumnToDelete = null;
            decorativeColumnToDelete = _context.DecorativeColumns
                .Where(d =>
                (d.Grid.GridId == grid.GridId && d.DecorativeColumnId == decorativeColumn.DecorativeColumnId))
                .FirstOrDefault();

            _context.DecorativeColumns.Remove(decorativeColumnToDelete);
            _context.SaveChanges();

        }
    }
}
