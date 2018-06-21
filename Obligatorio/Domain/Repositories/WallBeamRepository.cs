using Domain.Entities;
using Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Repositories
{
    public class WallBeamRepository : IWallBeamRepository
    {
        public DatabaseContext _context;

        public WallBeamRepository(GridRepository gridRepository)
        {
            this._context = gridRepository._context;
        }

        public void Add(Grid grid, WallBeam wallBeam, PriceAndCost priceAndCost)
        {
            try
            {
                PriceAndCost priceCost = _context.PricesAndCosts
                .Where(w => w.PriceAndCostId == priceAndCost.PriceAndCostId)
                .FirstOrDefault();
                wallBeam.PriceAndCost = priceCost;
                _context.Grids.Attach(grid);
                wallBeam.Grid = grid;
                _context.WallBeams.Add(wallBeam);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
            }
        }

        public int Count(Grid grid)
        {
            return this.GetList(grid).Count;
        }

        public WallBeam Get(Grid grid, Point ubicationPoint)
        {
            _context.Points.Attach(ubicationPoint);

            return _context.WallBeams
                .Where(w =>
                (w.Grid.GridId == grid.GridId 
                && w.UbicationPoint.X == ubicationPoint.X 
                && w.UbicationPoint.Y == ubicationPoint.Y))
                .FirstOrDefault();
        }

        public List<WallBeam> GetList(Grid grid)
        {
            try
            {
                List<WallBeam> wallBeamList = null;
                wallBeamList = _context.WallBeams
                    .Where(w => w.Grid.GridId == grid.GridId)
                    .ToList();
                return wallBeamList;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public bool Exist(Grid grid, Point ubicationPoint)
        {
            WallBeam wallBeamToFind = null;
            wallBeamToFind = _context.WallBeams
                .Where(w => (w.Grid.GridId == grid.GridId
                && w.UbicationPoint.X == ubicationPoint.X)
                && w.UbicationPoint.Y == ubicationPoint.Y)
                .FirstOrDefault();

            return !(wallBeamToFind == null);
        }

        public void Remove(Grid grid, WallBeam wallBeam)
        {
            WallBeam wallBeamToDelete = null;
            wallBeamToDelete = _context.WallBeams
                .Where(w =>
                (w.Grid.GridId == grid.GridId && w.WallBeamId == wallBeam.WallBeamId))
                .FirstOrDefault();
            
            _context.WallBeams.Remove(wallBeamToDelete);
            _context.SaveChanges();
        }

        public WallBeam GetFirst()
        {
            return _context.WallBeams.Where(w => w.WallBeamId == 1).FirstOrDefault();
        }
    }
}
