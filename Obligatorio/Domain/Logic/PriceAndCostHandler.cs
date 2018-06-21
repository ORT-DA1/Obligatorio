using Domain.Entities;
using Domain.Interface;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Logic
{
    public class PriceAndCostHandler
    {
        private IPriceAndCostRepository priceAndCostRepository;

        public PriceAndCostHandler()
        {
            this.priceAndCostRepository = new PriceAndCostRepository();
        }

        public void DecorativeColumnModifyPriceCost(int cost, int price)
        {
            priceAndCostRepository.DecorativeColumnModifyPriceCost(cost, price);
        }

        public void DoorModifyPriceCost(int cost, int price)
        {
            priceAndCostRepository.DoorModifyPriceCost(cost, price);
        }

        public void WallModifyPriceCost(int cost, int price)
        {
            priceAndCostRepository.WallModifyPriceCost(cost, price);
        }

        public void WallBeamColumnModifyPriceCost(int cost, int price)
        {
            priceAndCostRepository.WallBeamColumnModifyPriceCost(cost, price);
        }

        public void SetCostAndPriceWall(int v1, int v2)
        {
            throw new NotImplementedException();
        }

        public void WindowModifyPriceCost(int cost, int price)
        {
            priceAndCostRepository.WindowModifyPriceCost(cost, price);
        }

        public void SetCostAndPriceWallBeam(int v1, int v2)
        {
            throw new NotImplementedException();
        }

        public object GetWallCost()
        {
            throw new NotImplementedException();
        }

        public void SetCostAndPriceWindow(int v1, int v2)
        {
            throw new NotImplementedException();
        }

        public void SetCostAndPriceDecorativeColumn(int v1, int v2)
        {
            throw new NotImplementedException();
        }

        public void SetCostAndPriceDoor(int v1, int v2)
        {
            throw new NotImplementedException();
        }

        public object GetWallPrice()
        {
            throw new NotImplementedException();
        }

        public object GetDoorCost()
        {
            throw new NotImplementedException();
        }

        public object GetDoorPrice()
        {
            throw new NotImplementedException();
        }

        public object GetWindowPrice()
        {
            throw new NotImplementedException();
        }

        public object GetWallBeamCost()
        {
            throw new NotImplementedException();
        }

        public object GetWallBeamPrice()
        {
            throw new NotImplementedException();
        }

        public object GetWindowCost()
        {
            throw new NotImplementedException();
        }
    }
}
