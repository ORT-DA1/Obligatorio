using System;
using Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;

namespace UnitTest
{
    [TestClass]
    public class GridTest
    {
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
            return true;
        }
    }
}
