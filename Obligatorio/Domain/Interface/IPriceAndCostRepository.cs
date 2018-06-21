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
    }
}
