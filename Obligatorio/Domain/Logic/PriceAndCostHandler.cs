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

        public void WindowModifyPriceCost(int cost, int price)
        {
            priceAndCostRepository.WindowModifyPriceCost(cost, price);
        }
    }
}
