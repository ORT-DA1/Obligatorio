using Domain.Data;
using Domain.Entities;
using Domain.Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace UnitTest
{
    [TestClass]
    public class GridTest
    {
        private List<Wall> Walls;
        private List<WallBeam> WallBeams;
        private List<Opening> Openings;
        private DataStorage dataStorage;
        private readonly GridHandler GRID_HANDLER;
        private readonly int HEIGHT = 100;
        private readonly int WIDTH = 100;
        private readonly string USERNAME_OK = "invict1";
        private readonly string PASSWORD_OK = "invict2";
        private readonly string NAME_OK = "Pablo";
        private readonly string SURNAME_OK = "Pereira";
        private readonly DateTime DATE_OK = new DateTime(1997, 07, 24);
        private readonly string ID_OK = "5407935-1";
        private readonly int PHONE_OK = 093535851;
        private readonly string ADDRESS_OK = "Brasil 1744";

        public GridTest()
        {
            this.GRID_HANDLER = new GridHandler();
            this.dataStorage = DataStorage.GetStorageInstance();
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
            Designer designer = new Designer(USERNAME_OK, PASSWORD_OK, NAME_OK, SURNAME_OK, DATE_OK, null);
            Client client = new Client(USERNAME_OK, PASSWORD_OK, NAME_OK, SURNAME_OK, ID_OK, PHONE_OK, ADDRESS_OK, DATE_OK, null);
            Grid grid = new Grid(designer, client, HEIGHT, WIDTH);
            Assert.IsTrue(grid.Designer.Equals(designer) && grid.Client.Equals(client) && grid.Height.Equals(HEIGHT)
                && grid.Width.Equals(WIDTH));
            
        }

        [TestMethod]
        public void TestAddWall()
        {
            int expectedResult = Walls.Count + 1;
            Wall wall = new Wall();
            Walls.Add(wall);
            Assert.AreEqual(expectedResult,Walls.Count);
        }

        [TestMethod]
        public void TestAddWallBeam()
        {
            int expectedResult = WallBeams.Count + 1;
            WallBeam wallBeam = new WallBeam();
            WallBeams.Add(wallBeam);
            Assert.AreEqual(expectedResult, WallBeams.Count);
        }

        [TestMethod]
        public void TestAddOpening()
        {
            int expectedResult = Openings.Count + 1;
            Opening opening = new Opening();
            Openings.Add(opening);
            Assert.AreEqual(expectedResult, Openings.Count);
        }

        [TestMethod]
        public void TestRemoveWall()
        {
            Wall wall = new Wall();
            Walls.Add(wall);
            int expectedResult = Walls.Count - 1;
            Walls.Remove(wall);
            Assert.AreEqual(expectedResult, Walls.Count);
        }

        [TestMethod]
        public void TestRemoveWallBeam()
        {
            WallBeam wallBeam = new WallBeam();
            WallBeams.Add(wallBeam);
            int expectedResult = WallBeams.Count - 1;
            WallBeams.Remove(wallBeam);
            Assert.AreEqual(expectedResult, WallBeams.Count);
        }

        [TestMethod]
        public void TestRemoveOpening()
        {
            Opening opening = new Opening();
            Openings.Add(opening);
            int expectedResult = Openings.Count - 1;
            Openings.Remove(opening);
            Assert.AreEqual(expectedResult, Openings.Count);
        }

        [TestMethod]
        public void TestAddGrid() {
            Designer designer = new Designer(USERNAME_OK, PASSWORD_OK, NAME_OK, SURNAME_OK, DATE_OK, null);
            Client client = new Client(USERNAME_OK, PASSWORD_OK, NAME_OK, SURNAME_OK, ID_OK, PHONE_OK, ADDRESS_OK, DATE_OK, null);
            Grid grid = new Grid(designer, client, HEIGHT, WIDTH);
            GRID_HANDLER.Add(grid);
            Assert.IsTrue(dataStorage.Grids.Contains(grid));
        }
    }
}
