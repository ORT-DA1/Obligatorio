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

        #region Constructor
        public PriceAndCostHandler(GridRepository gridRepository)
        {
            this.priceAndCostRepository = new PriceAndCostRepository(gridRepository);
        }
        #endregion

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

        #region Get Element Price and Cost

        public int GetWallCost()
        {
            return priceAndCostRepository.GetWallCost();
        }

        public PriceAndCost GetPriceAndCostWall()
        {
            return priceAndCostRepository.GetPriceAndCostWallBeam();
        }
        public PriceAndCost GetPriceAndCostWallBeam()
        {
            return priceAndCostRepository.GetPriceAndCostWallBeam();
        }
        public PriceAndCost GetPriceAndCostWindow()
        {
            return priceAndCostRepository.GetPriceAndCostWindow();
        }
        public PriceAndCost GetPriceAndCostDoor()
        {
            return priceAndCostRepository.GetPriceAndCostDoor();
        }
        public PriceAndCost GetPriceAndCostDecorativeColumn()
        {
            return priceAndCostRepository.GetPriceAndCostDecorativeColumn();
        }
        public int GetWallPrice()
        {
            return priceAndCostRepository.GetWallPrice();
        }

        public int GetDoorCost()
        {
            return priceAndCostRepository.GetDoorCost();
        }

        public int GetDoorPrice()
        {
            return priceAndCostRepository.GetDoorPrice();
        }

        public int GetWindowPrice()
        {
            return priceAndCostRepository.GetWindowPrice();
        }

        public int GetWallBeamCost()
        {
            return priceAndCostRepository.GetWallBeamCost();
        }

        public int GetWallBeamPrice()
        {
            return priceAndCostRepository.GetWallBeamPrice();
        }

        public int GetWindowCost()
        {
            return priceAndCostRepository.GetWindowCost();
        }

        public int TotalCostWindow(Grid grid)
        {
            return priceAndCostRepository.TotalCostWindow(grid);
        }

        public int TotalPriceWall(Grid grid)
        {
            return priceAndCostRepository.TotalPriceWall(grid);
        }

        public int TotalCostWallBeam(Grid grid)
        {
            return priceAndCostRepository.TotalCostWallBeam(grid);
        }

        public int TotalPriceWallBeam(Grid grid)
        {
            return priceAndCostRepository.TotalPriceWallBeam(grid);
        }

        public int TotalPriceWindow(Grid grid)
        {
            return priceAndCostRepository.TotalPriceWindow(grid);
        }

        public int TotalCost(Grid grid)
        {
            return TotalCostWall(grid) 
                + TotalCostWallBeam(grid) 
                + TotalCostWindow(grid)
                + TotalCostDoor(grid)
                + TotalCostDecorativeColumn(grid);
        }

        private int TotalCostDecorativeColumn(Grid grid)
        {
            return priceAndCostRepository.TotalCostDecorativeColumn(grid);
        }

        public int TotalCostDoor(Grid grid)
        {
            return priceAndCostRepository.TotalCostDoor(grid);
        }

        public int TotalPriceDoor(Grid grid)
        {
            return priceAndCostRepository.TotalPriceDoor(grid);
        }

        public int TotalCostWall(Grid grid)
        {
            return priceAndCostRepository.TotalCostWall(grid);
        }

        public object GetDecorativeColumnCost()
        {
            return priceAndCostRepository.GetDecorativeColumnCost();
        }

        public object GetDecorativeColumnPrice()
        {
            return priceAndCostRepository.GetDecorativeColumnPrice();
        }

        #endregion
    }
}
