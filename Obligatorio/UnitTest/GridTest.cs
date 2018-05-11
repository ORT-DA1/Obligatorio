using Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTest
{
    [TestClass]
    public class GridTest
    {
        public List<Wall> Walls = new List<Wall>();
        public List<WallBeam> WallBeams = new List<WallBeam>();
        public List<Opening> Openings = new List<Opening>();

        public readonly Designer designer = new Designer();
        public readonly Client client = new Client();
        public readonly int HEIGHT = 100;
        public readonly int WIDTH = 100;

        [TestMethod]
        public void TestCreateGridWithoutParameters()
        {
            Grid grid = new Grid();
            Assert.IsNotNull(grid);
        }

        [TestMethod]
        public void TestCreateGridWithParameters()
        {
            Grid grid = new Grid(designer, client, HEIGHT, WIDTH);
            Assert.IsTrue(grid.Designer.Equals(designer) && grid.Height.Equals(HEIGHT)
                && grid.Width.Equals(WIDTH));
            //grid.Client.Equals(client) &&
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
        }

        [TestMethod]
        public void TestRemoveWallBeam(Wall wall)
        {

        }

        [TestMethod]
        public void TestRemoveOpening(Wall wall)
        {
            
        }

    }
}
