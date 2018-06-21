using Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Repositories
{
    public class PriceAndCostRepository : IPriceAndCostRepository
    {
        public DatabaseContext _context;
        public PriceAndCostRepository()
        {
            this._context = new DatabaseContext();
        }

        public void DecorativeColumnModifyPriceCost(int cost, int price)
        {
            throw new NotImplementedException();
        }

        public void DoorModifyPriceCost(int cost, int price)
        {
            throw new NotImplementedException();
        }

        public void WallBeamColumnModifyPriceCost(int cost, int price)
        {
            throw new NotImplementedException();
        }

        public void WallModifyPriceCost(int cost, int price)
        {
            throw new NotImplementedException();
        }

        public void WindowModifyPriceCost(int cost, int price)
        {
            throw new NotImplementedException();
        }

        internal int TotalCostWindow(Grid grid)
        {
            throw new NotImplementedException();
        }

        internal int TotalPriceWall(Grid grid)
        {
            throw new NotImplementedException();
        }

        internal int TotalCostWallBeam(Grid grid)
        {
            throw new NotImplementedException();
        }

        internal int TotalPriceWallBeam(Grid grid)
        {
            throw new NotImplementedException();
        }
    }
}
