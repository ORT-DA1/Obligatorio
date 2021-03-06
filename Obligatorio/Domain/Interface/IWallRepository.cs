﻿using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Interface
{
    public interface IWallRepository
    {
        void Add(Grid grid, Wall wall, PriceAndCost priceAndCost);
        List<Wall> GetList(Grid grid);
        void Remove(Grid grid, Wall intersectWall);
        List<Point> GetWallPath(Wall wall);
        Wall ObtainWallInPoint(Grid grid, Point point);
        Wall GetFirst();
    }
}
