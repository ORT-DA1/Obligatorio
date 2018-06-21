using Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Logic;

namespace Domain.Repositories
{
    public class PriceAndCostRepository : IPriceAndCostRepository
    {
        DecorativeColumnHandler decorativeColumnHandler;
        DoorHandler doorHandler;
        WallHandler wallHandler;
        WindowHandler windowHandler;
        WallBeamHandler wallBeamHandler;

        public DatabaseContext _context;
        public PriceAndCostRepository(GridRepository gridRepository)
        {
            wallHandler = new WallHandler(gridRepository);
            windowHandler = new WindowHandler(gridRepository);
            wallBeamHandler = new WallBeamHandler(gridRepository);
            doorHandler = new DoorHandler(gridRepository);
            decorativeColumnHandler = new DecorativeColumnHandler(gridRepository);
            this._context = new DatabaseContext();
        }

        #region Modify Price and Cost

        public void DecorativeColumnModifyPriceCost(int cost, int price)
        {
            DecorativeColumn decorativeColumn = decorativeColumnHandler.GetFirst();
            PriceAndCost priceAndCost = _context.PricesAndCosts
                .Where(p => p.PriceAndCostId == decorativeColumn.PriceAndCost.PriceAndCostId)
                .First();
            priceAndCost.Cost = cost;
            priceAndCost.Price = price;
            _context.SaveChanges();
        }

        public void DoorModifyPriceCost(int cost, int price)
        {
            Door door = doorHandler.GetFirst();
            PriceAndCost priceAndCost = _context.PricesAndCosts
                .Where(p => p.PriceAndCostId == door.PriceAndCost.PriceAndCostId)
                .First();
            priceAndCost.Cost = cost;
            priceAndCost.Price = price;
            _context.SaveChanges();
        }

        public void WallBeamColumnModifyPriceCost(int cost, int price)
        {
            WallBeam wallBeam = wallBeamHandler.GetFirst();
            PriceAndCost priceAndCost = _context.PricesAndCosts
                .Where(p => p.PriceAndCostId == wallBeam.PriceAndCost.PriceAndCostId)
                .First();
            priceAndCost.Cost = cost;
            priceAndCost.Price = price;
            _context.SaveChanges();
        }

        public void WallModifyPriceCost(int cost, int price)
        {
            Wall wall = wallHandler.GetFirst();
            PriceAndCost priceAndCost = _context.PricesAndCosts
                .Where(p => p.PriceAndCostId == wall.PriceAndCost.PriceAndCostId)
                .First();
            priceAndCost.Cost = cost;
            priceAndCost.Price = price;
            _context.SaveChanges();
        }

        public void WindowModifyPriceCost(int cost, int price)
        {
            Window window = windowHandler.GetFirst();
            PriceAndCost priceAndCost = _context.PricesAndCosts
                .Where(p => p.PriceAndCostId == window.PriceAndCost.PriceAndCostId)
                .First();
            priceAndCost.Cost = cost;
            priceAndCost.Price = price;
            _context.SaveChanges();
        }

        #endregion

        #region Element Total Cost and Price
        public int TotalPriceWall(Grid grid)
        {
            List<Wall> wallList = wallHandler.GetList(grid);
            var total = 0;
            foreach (var item in wallList)
            {
                total += this.GetWallPrice();
            }
            return total;
        }

        public int TotalCostWall(Grid grid)
        {
            List<Wall> wallList = wallHandler.GetList(grid);
            var total = 0;
            foreach (var item in wallList)
            {
                total += this.GetWallCost();
            }
            return total;
        }

        public int TotalCostWallBeam(Grid grid)
        {
            List<WallBeam> wallBeamList = wallBeamHandler.GetList(grid);
            var total = 0;
            foreach (var item in wallBeamList)
            {
                total += this.GetWallBeamCost();
            }
            return total;
        }

        public int TotalPriceWallBeam(Grid grid)
        {
            List<WallBeam> wallBeamList = wallBeamHandler.GetList(grid);
            var total = 0;
            foreach (var item in wallBeamList)
            {
                total += this.GetWallBeamPrice();
            }
            return total;
        }

        public int TotalCostWindow(Grid grid)
        {
            List<Window> windowList = windowHandler.GetList(grid);
            var total = 0;
            foreach (var item in windowList)
            {
                total += this.GetWindowCost();
            }
            return total;
        }

        public int TotalPriceWindow(Grid grid)
        {
            List<Window> windowList = windowHandler.GetList(grid);
            var total = 0;
            foreach (var item in windowList)
            {
                total += this.GetWindowPrice();
            }
            return total;
        }

        public int TotalCostDoor(Grid grid)
        {
            List<Door> doorList = doorHandler.GetList(grid);
            var total = 0;
            foreach (var item in doorList)
            {
                total += this.GetDoorCost();
            }
            return total;
        }

        public int TotalPriceDoor(Grid grid)
        {
            List<Door> doorList = doorHandler.GetList(grid);
            var total = 0;
            foreach (var item in doorList)
            {
                total += this.GetDoorPrice();
            }
            return total;
        }

        public int TotalCostDecorativeColumn(Grid grid)
        {
            List<DecorativeColumn> decorativeColumnList = decorativeColumnHandler.GetList(grid);
            var total = 0;
            foreach (var item in decorativeColumnList)
            {
                total += this.GetDecorativeColumnCost();
            }
            return total;
        }
        public int TotalPriceDecorativeColumn(Grid grid)
        {
            List<DecorativeColumn> decorativeColumnList = decorativeColumnHandler.GetList(grid);
            var total = 0;
            foreach (var item in decorativeColumnList)
            {
                total += this.GetDecorativeColumnPrice();
            }
            return total;
        }

        public int TotalCost(Grid grid)
        {
            return TotalCostDoor(grid)
                + TotalCostWallBeam(grid)
                + TotalCostWindow(grid)
                + TotalCostWall(grid)
                + TotalCostDecorativeColumn(grid);
        }

        #endregion

        #region Get Element Price and Cost
        public int GetWindowCost()
        {
            PriceAndCost priceAndCost = _context.PricesAndCosts
                .Where(p => p.PriceAndCostId == 3)
                .FirstOrDefault();
            return priceAndCost.Cost;
        }

        public int GetWallBeamPrice()
        {
            PriceAndCost priceAndCost = _context.PricesAndCosts
                .Where(p => p.PriceAndCostId == 2)
                .FirstOrDefault();
            return priceAndCost.Price;
        }

        public int GetWallBeamCost()
        {
            PriceAndCost priceAndCost = _context.PricesAndCosts
                .Where(p => p.PriceAndCostId == 2)
                .FirstOrDefault();
            return priceAndCost.Cost;
        }

        public int GetDoorCost()
        {
            PriceAndCost priceAndCost = _context.PricesAndCosts
                .Where(p => p.PriceAndCostId == 4)
                .FirstOrDefault();
            return priceAndCost.Cost;
        }

        public int GetWallPrice()
        {
            PriceAndCost priceAndCost = _context.PricesAndCosts
                .Where(p => p.PriceAndCostId == 1)
                .FirstOrDefault();
            return priceAndCost.Price;
        }

        public int GetWallCost()
        {
            PriceAndCost priceAndCost = _context.PricesAndCosts
                .Where(p => p.PriceAndCostId == 1)
                .FirstOrDefault();
            return priceAndCost.Cost;
        }

        public int GetDecorativeColumnPrice()
        {
            PriceAndCost priceAndCost = _context.PricesAndCosts
                .Where(p => p.PriceAndCostId == 5)
                .FirstOrDefault();
            return priceAndCost.Price;
        }

        public int GetDecorativeColumnCost()
        {
            PriceAndCost priceAndCost = _context.PricesAndCosts
                .Where(p => p.PriceAndCostId == 5)
                .FirstOrDefault();
            return priceAndCost.Cost;
        }

        public int GetWindowPrice()
        {
            PriceAndCost priceAndCost = _context.PricesAndCosts
                .Where(p => p.PriceAndCostId == 3)
                .FirstOrDefault();
            return priceAndCost.Price;
        }

        public int GetDoorPrice()
        {
            PriceAndCost priceAndCost = _context.PricesAndCosts
                .Where(p => p.PriceAndCostId == 4)
                .FirstOrDefault();
            return priceAndCost.Price;
        }

        public PriceAndCost GetPriceAndCostWall()
        {
            Wall wall = wallHandler.GetFirst();
            PriceAndCost priceAndCost = _context.PricesAndCosts
                .Where(p => p.PriceAndCostId == 1)
                .FirstOrDefault();
            return priceAndCost;
        }

        public PriceAndCost GetPriceAndCostWallBeam()
        {
            WallBeam wallBeam = wallBeamHandler.GetFirst();
            PriceAndCost priceAndCost = _context.PricesAndCosts
                .Where(p => p.PriceAndCostId == 2)
                .FirstOrDefault();
            return priceAndCost;
        }

        public PriceAndCost GetPriceAndCostWindow()
        {
            Window window = windowHandler.GetFirst();
            PriceAndCost priceAndCost = _context.PricesAndCosts
                .Where(p => p.PriceAndCostId == 3)
                .FirstOrDefault();
            return priceAndCost;
        }

        public PriceAndCost GetPriceAndCostDoor()
        {
            Door door = doorHandler.GetFirst();
            PriceAndCost priceAndCost = _context.PricesAndCosts
                .Where(p => p.PriceAndCostId == 4)
                .FirstOrDefault();
            return priceAndCost;
        }

        public PriceAndCost GetPriceAndCostDecorativeColumn()
        {
            DecorativeColumn decorativeColumn = decorativeColumnHandler.GetFirst();
            PriceAndCost priceAndCost = _context.PricesAndCosts
                .Where(p => p.PriceAndCostId == 5)
                .FirstOrDefault();
            return priceAndCost;
        }

        #endregion
    }
}
