using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface
{
    public interface IPriceAndCostRepository
    {
        void DecorativeColumnModifyPriceCost(int cost, int price);
        void DoorModifyPriceCost(int cost, int price);
        void WallModifyPriceCost(int cost, int price);
        void WallBeamColumnModifyPriceCost(int cost, int price);
        void WindowModifyPriceCost(int cost, int price);

        int GetDecorativeColumnPrice();
        int GetDecorativeColumnCost();
        int GetWindowCost();
        int GetWindowPrice();
        int GetWallBeamPrice();
        int GetWallBeamCost();
        int GetDoorPrice();
        int GetDoorCost();
        int GetWallPrice();
        int GetWallCost();

        int TotalPriceWall(Grid grid);
        int TotalCostWall(Grid grid);
        int TotalPriceWallBeam(Grid grid);
        int TotalCostWallBeam(Grid grid);
        int TotalPriceWindow(Grid grid);
        int TotalCostWindow(Grid grid);
        int TotalPriceDoor(Grid grid);
        int TotalCostDoor(Grid grid);
        int TotalPriceDecorativeColumn(Grid grid);
        int TotalCostDecorativeColumn(Grid grid);
        PriceAndCost GetPriceAndCostWallBeam();
        PriceAndCost GetPriceAndCostWindow();
        PriceAndCost GetPriceAndCostDoor();
        PriceAndCost GetPriceAndCostDecorativeColumn();
    }
}
