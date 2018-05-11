﻿using Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTest
{
    [TestClass]
    public class GridTest
    {
        private readonly List<Wall> WALLS;
        private readonly List<WallBeam> WALL_BEAMS;
        private readonly List<Opening> OPENINGS;

        [TestMethod]
        public void TestCreateGridWithoutParameters()
        {
            Grid grid = new Grid();
            Assert.IsNotNull(grid);
        }

        [TestMethod]
        public void TestCreateGridWithParameters(Designer designer, Client client, int height ,int width)
        {
            Grid grid = new Grid(designer, client, height, width);
            Assert.IsTrue(grid.Designer.Equals(designer) && grid.Client.Equals(client) && grid.Height.Equals(height) 
                && grid.Width.Equals(width));
        }

        [TestMethod]
        public void TestAddWall(Wall wall)
        {

        }

        [TestMethod]
        public void TestAddWallBeam(WallBeam wallBeam)
        {

        }

        [TestMethod]
        public void TestAddOpening(Opening opening)
        {

        }

        [TestMethod]
        public void TestRemoveWall(Wall wall)
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
