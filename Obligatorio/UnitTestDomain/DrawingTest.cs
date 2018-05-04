using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Drawing;

namespace UnitTestDomain
{
    [TestClass]
    public class DrawingTest
    {
        private List<MockWall> walls;

        [TestMethod]
        public bool Drawing()
        {
            return true;
        }

        [TestMethod]
        public bool Drawing(int width, int height)
        {
            return true;
        }

        [TestMethod]
        public bool AddWall(MockWall wall)
        {
            return true;
        }

        [TestMethod]
        public bool GetWalls()
        {
            return true;
        }

        [TestMethod]
        public bool RemoveWall()
        {
            return true;
        }

        [TestMethod]
        public bool DrawWalls(Graphics graphic)
        {
            return true;
        }

        [TestMethod]
        public bool DrawGrid(Graphics graphic)
        {
            return true;
        }

        [TestMethod]
        public bool DrawX(Graphics graphic)
        {
            return true;
        }

        [TestMethod]
        public bool FixWalls(Point startWall, Point endWall)
        {
            return true;
        }

    }

}