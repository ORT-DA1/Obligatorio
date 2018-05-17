using Domain.Data;
using Domain.Entities;
using Domain.Exceptions;
using Domain.Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace UnitTest
{
    [TestClass]
    public class GridTest
    {
        private DataStorage dataStorage;
        private readonly GridHandler GRID_HANDLER;
        private readonly int HEIGHT = 20;
        private readonly int WIDTH = 20;
        private readonly string USERNAME_OK = "pablo";
        private readonly string PASSWORD_OK = "pablo";
        private readonly string NAME_OK = "Pablo";
        private readonly string SURNAME_OK = "Pereira";
        private readonly DateTime DATE_OK = new DateTime(1997, 07, 24);
        private readonly string ID_OK = "5407935-1";
        private readonly string PHONE_OK = "093535851";
        private readonly string ADDRESS_OK = "Brasil 1744";
        private readonly string GRID_NAME_OK = "grid name";
        private readonly int PIXEL_CONVERTION = 25;
        private readonly Client client;
        private readonly Grid grid;


        public GridTest()
        {
            this.GRID_HANDLER = new GridHandler();
            this.dataStorage = DataStorage.GetStorageInstance();
            this.client = new Client(USERNAME_OK, PASSWORD_OK, NAME_OK, SURNAME_OK, ID_OK, PHONE_OK, ADDRESS_OK, DATE_OK, null);
            this.grid = new Grid(GRID_NAME_OK, client, HEIGHT, WIDTH);

        }

        [TestInitialize]
        public void TestCleanUp()
        {
            dataStorage.EmptyStorage();
        }

        [TestMethod]
        public void TestCreateGridWithoutParameters()
        {
            Grid grid = new Grid();
            Assert.IsNotNull(grid);
        }

        [TestMethod]
        public void TestCreateGridWithParameters()
        {
            Assert.IsTrue(grid.Client.Equals(client) && (grid.Height / PIXEL_CONVERTION).Equals(HEIGHT)
                && (grid.Width / PIXEL_CONVERTION).Equals(WIDTH));
        }

        [TestMethod]
        public void TestAddGrid() {
            GRID_HANDLER.Add(grid);
            Assert.IsTrue(dataStorage.Grids.Contains(grid));
        }

        [TestMethod]
        public void TestGetGrid()
        {
            GRID_HANDLER.Add(grid);
            Grid resultGrid = GRID_HANDLER.Get(client);
            Assert.AreEqual(grid, resultGrid);
        }

        [TestMethod]
        [ExpectedException(typeof(ExceptionController))]
        public void TestDeleteGrid()
        {
            Client anotherClient = new Client("testasdas", PASSWORD_OK, NAME_OK, SURNAME_OK, ID_OK, PHONE_OK, ADDRESS_OK, DATE_OK, null);
            Grid anotherGrid = new Grid(GRID_NAME_OK, anotherClient, HEIGHT, WIDTH);
            GRID_HANDLER.Add(anotherGrid);
            GRID_HANDLER.Delete(anotherGrid);
            Assert.IsFalse(dataStorage.Grids.Contains(anotherGrid));
        }

        [TestMethod]
        public void TestExistGrid()
        {
            Client client = new Client(USERNAME_OK, PASSWORD_OK, NAME_OK, SURNAME_OK, ID_OK, PHONE_OK, ADDRESS_OK, DATE_OK, null);
            Grid anotherGrid = new Grid(GRID_NAME_OK, client, HEIGHT, WIDTH);
            GRID_HANDLER.Add(anotherGrid);
        }

        [TestMethod]
        public void TestIsCuttingAWallTrue()
        {
            Wall wall = new Wall(new Point(0, 1), new Point(0, 5));
            Wall anotherWall = new Wall(new Point(3, 0), new Point(3, 2));
            grid.Walls.Add(wall);
            grid.Walls.Add(anotherWall);
            bool expectedResult = true;
            bool result = grid.isCuttingAWallBeforeMaximum(anotherWall);
            Assert.AreEqual(result,expectedResult);
        }

        [TestMethod]
        public void TestisCuttingAWallFalse()
        {
            Wall wall = new Wall(new Point(0, 1), new Point(0, 5));
            Wall anotherWall = new Wall(new Point(6, 4), new Point(8, 4));
            grid.Walls.Add(wall);
            bool expectedResult = false;
            bool result = grid.isCuttingAWallBeforeMaximum(anotherWall);
            Assert.AreEqual(result,expectedResult);
        }

        [TestMethod]
        public void TestValidWallBeamTrue()
        {
            Point point = new Point(0, 1);
            bool result = grid.FreePosition(point);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestValidWallBeamFalse()
        {
            Point point = new Point(0, 1);
            WallBeam wallBeam = new WallBeam(point);
            grid.WallBeams.Add(wallBeam);
            WallBeam anotherWallBeam = new WallBeam(point);
            bool expectedResult = false;
            bool result = grid.FreePosition(point);
            Assert.AreEqual(result, expectedResult);
        }

        [TestMethod]
        public void TestRemoveWall()
        {
            Wall wall = new Wall(new Point(0, 1), new Point(0, 5));
            grid.Walls.Add(wall);
            Wall anotherwall = new Wall(new Point(0, 6), new Point(0, 10));
            grid.Walls.Add(anotherwall);
            grid.Walls.Remove(wall);
            bool resultExpected = true;
            bool result = grid.Walls.Count.Equals(1);
            Assert.AreEqual(resultExpected, result);
        }

        [TestMethod]
        public void TestGetWallBeam()
        {
            Point point = new Point(0, 1);
            WallBeam wallBeam = new WallBeam(point);
            grid.WallBeams.Add(wallBeam);
            WallBeam expectedResult = grid.getWallBeam(point);
            Assert.AreEqual(wallBeam, expectedResult); 
        }

        [TestMethod]
        public void TestRemoveWallBeam()
        {
            Point point = new Point(0, 1);
            WallBeam wallBeam = new WallBeam(point);
            Point anotherPoint = new Point(0, 5);
            WallBeam anotherWallBeam = new WallBeam(anotherPoint);
            grid.WallBeams.Add(anotherWallBeam);
            grid.WallBeams.Add(wallBeam);
            grid.WallBeams.Remove(wallBeam);
            bool resultExpected = true;
            bool result = grid.WallBeams.Count.Equals(1);
            Assert.AreEqual(resultExpected, result);
        }

        [TestMethod]
        public void TestContainsPoint()
        {
            List<Point> pointList = new List<Point>();
            Point point = new Point(0, 1);
            pointList.Add(point);
            bool result = grid.ContainsPoint(pointList, point);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestEqual()
        {
            Grid anotherGrid = new Grid(GRID_NAME_OK, client, HEIGHT, WIDTH);
            Assert.AreEqual(grid, anotherGrid);
        }
        
        [TestMethod]
        public void TestRemoveWindow()
        {
            Point anotherPoint = new Point(1, 1);
            Point otherPoint = new Point(100, 0);
            Window anotherWindow = new Window(otherPoint, anotherPoint, "vertical");
            Point point = new Point(1, 0);
            Window window = new Window(point, anotherPoint, "vertical");
            grid.Windows.Add(window);
            grid.RemoveWindow(window);
            int expectedResult = 1;
            int result = grid.Windows.Count;
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ExceptionController))]
        public void TestOnTheWall()
        {
            Point point = new Point(1, 0);
            Point anotherPoint = new Point(1, 5);
            Point newPoint = new Point(1, 3);
            Wall wall = new Wall(point, anotherPoint);
            grid.Walls.Add(wall);
            grid.OnTheWall(newPoint);
        }

        [TestMethod]
        public void TestRemoveDoor()
        {
            Point point = new Point(0, 1);
            Point otherPoint = new Point(0, 100);
            Point anotherPoint = new Point(1, 1);
            Door anotherDoor = new Door(otherPoint, anotherPoint, "vertical");
            Door door = new Door(point, anotherPoint, "vertical");
            grid.Doors.Add(anotherDoor);
            grid.Doors.Add(door);
            grid.RemoveDoor(point);
            int expectedResult = 1;
            int result = grid.Doors.Count;
            Assert.AreEqual(expectedResult, result);
        }
        
        [TestMethod]
        public void TestMetersWallCount()
        {
            Wall wall = new Wall(new Point(0, 25), new Point(0, 100));
            grid.Walls.Add(wall);
            int expectedResult = 3;
            int result = grid.MetersWallCount();
            Assert.AreEqual(result, expectedResult);
        }

        [TestMethod]
        public void TestWallBeamsCount()
        {
            int expectedResult = this.grid.WallBeams.Count;
            int result = this.grid.WallBeamsCount();
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void TestWindowsCount()
        {
            int expectedResult = this.grid.Windows.Count;
            int result = this.grid.WindowsCount();
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void TestDoorsCount()
        {
            int expectedResult = this.grid.Doors.Count;
            int result = this.grid.DoorsCount();
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void TestAmountCostWall()
        {
            int costResult = this.grid.MetersWallCount() * this.grid.CostPriceWallBeam.Item1;
            int expectedCostResult = this.grid.AmountCostWallBeam();
            Assert.AreEqual(costResult, expectedCostResult);
        }

        [TestMethod]
        public void TestAmountPriceWall()
        {
            int costResult = this.grid.MetersWallCount() * this.grid.CostPriceWallBeam.Item2;
            int expectedCostResult = this.grid.AmountPriceWallBeam();
            Assert.AreEqual(costResult, expectedCostResult);
        }

        [TestMethod]
        public void TestAmountCostWallBeam()
        {
            int costResult = this.grid.WallBeamsCount() * this.grid.CostPriceWallBeam.Item1;
            int expectedCostResult = this.grid.AmountCostWallBeam();
            Assert.AreEqual(costResult, expectedCostResult);
        }

        [TestMethod]
        public void TestAmountPriceWallBeam()
        {
            int costResult = this.grid.WallBeamsCount() * this.grid.CostPriceWallBeam.Item2;
            int expectedCostResult = this.grid.AmountPriceWallBeam();
            Assert.AreEqual(costResult, expectedCostResult);
        }

        [TestMethod]
        public void TestAmountCostWindow()
        {
            int costResult = this.grid.WindowsCount() * this.grid.CostPriceWindow.Item1;
            int expectedCostResult = this.grid.AmountCostWindow();
            Assert.AreEqual(costResult, expectedCostResult);

        }

        [TestMethod]
        public void TestAmountPriceWindow()
        {
            int costResult = this.grid.WindowsCount() * this.grid.CostPriceWallBeam.Item2;
            int expectedCostResult = this.grid.AmountPriceWindow();
            Assert.AreEqual(costResult, expectedCostResult);
        }

        [TestMethod]
        public void TestAmountCostDoor()
        {
            int costResult = this.grid.DoorsCount() * this.grid.CostPriceDoor.Item1;
            int expectedCostResult = this.grid.AmountCostDoor();
            Assert.AreEqual(costResult, expectedCostResult);
        }

        [TestMethod]
        public void TestAmountPriceDoor()
        {
            int costResult = this.grid.DoorsCount() * this.grid.CostPriceDoor.Item2;
            int expectedCostResult = this.grid.AmountCostDoor();
            Assert.AreEqual(costResult, expectedCostResult);
        }

        [TestMethod]
        public void TestTotalCost()
        {
            int expectedResult = grid.AmountCostWall() + grid.AmountCostWallBeam() + grid.AmountCostWindow() + grid.AmountPriceDoor();
            int result = grid.totalCost();
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void TestTotalPrice()
        {
            int expectedResult = grid.AmountPriceWall() + grid.AmountPriceWallBeam() + grid.AmountPriceWindow() + grid.AmountPriceDoor();
            int result = grid.totalPrice();
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void modifyCostAndPrice()
        {
            Tuple<int, int> meterWall = new Tuple<int, int>(1,2);
            Tuple< int, int> wallBeam = new Tuple<int, int>(1, 2); 
            Tuple<int, int> window = new Tuple<int, int>(1, 2);
            Tuple< int, int> door = new Tuple<int, int>(1, 2);
            grid.modifyCostAndPrice(meterWall, wallBeam, window, door);
            Assert.IsTrue(meterWall.Equals(grid.CostPriceMeterWall) && wallBeam.Equals(grid.CostPriceWallBeam)
                && window.Equals(grid.CostPriceWindow) && door.Equals(grid.CostPriceDoor));
        }

        [TestMethod]
        public void TestContainsPoints() {
            Point point = new Point(0, 25);
            List<Point> pointList = new List<Point>();
            pointList.Add(point);
            bool result = grid.ContainsPoint(pointList, point);
            Assert.IsTrue(result);
        }

        [TestMethod]
        [ExpectedException(typeof(ExceptionController))]
        public void TestHorizontalOrVertical()
        {
            Wall wall = new Wall(new Point(0, 25), new Point(0, 100));
            GRID_HANDLER.ValidWallOrientation(wall);
        }

        [TestMethod]
        [ExpectedException(typeof(ExceptionController))]
        public void TestAlreadyExistWall()
        {
            Wall wall = new Wall(new Point(0, 25), new Point(0, 100));
            grid.Walls.Add(wall);
            grid.AlreadyExistWall(wall);
        }

        [TestMethod]
        public void TestBreakWall()
        {
            Wall wall = new Wall(new Point(0, 25), new Point(0, 100));
            grid.Walls.Add(wall);
            int expectedResult = grid.Walls.Count + 1;
            grid.breakWall(wall, new Point(0,50));
            int result = grid.Walls.Count;
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void TestFixPoint()
        {
            Point point = new Point(26, 26);
            grid.fixPoint(point);
            Point anotherPoint = new Point(25, 25);
            Assert.AreEqual(point, anotherPoint);
        }

        [TestMethod]
        public void TestGetGridName()
        {
            Grid anotherGrid = new Grid("testName", client, 20, 20);
            string expectedResult = "testName";
            string result = anotherGrid.GridName;
            Assert.AreEqual(result, expectedResult);
        }

        [TestMethod]
        public void TestHasTwoPointsInCommon()
        {
            Wall wall = new Wall(new Point(25, 0), new Point(100, 0));
            Wall anotherWall = new Wall(new Point(25, 0), new Point(100, 0));
            bool result = grid.HasTwoPointsInCommon(wall,anotherWall);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestIsCuttingAWallBeforeMaximum()
        {
            Wall wall = new Wall(new Point(25, 25), new Point(100, 25));
            Wall anotherWall = new Wall(new Point(50, 0), new Point(50, 100));
            grid.Walls.Add(anotherWall);
            bool result = grid.isCuttingAWallBeforeMaximum(wall);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestIsPerpendicular()
        {
            Wall wall = new Wall(new Point(25, 25), new Point(100, 25));
            Wall anotherWall = new Wall(new Point(50, 0), new Point(50, 100));
            bool result = grid.isPerpendicular(wall,anotherWall);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestObtainWallInPoint()
        {
            Wall wall = new Wall(new Point(25, 25), new Point(100, 25));
            grid.Walls.Add(wall);
            Wall resultWall = grid.obtainWallInPoint(new Point(25, 25));
            Assert.AreEqual(wall, resultWall);
        }
    }
}
