using Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;

namespace UnitTest
{
    [TestClass]
    public class WallTest
    {
        public readonly Point START_POINT = new Point(10, 10);
        public readonly Point END_POINT = new Point(10, 20);

        [TestMethod]
        public void TestCreateWall()
        {
            Wall wall = new Wall(START_POINT, END_POINT);
            Assert.IsNotNull(wall);
        }

        [TestMethod]
        public void TestEqual()
        {
            Wall wall = new Wall(START_POINT, END_POINT);
            Wall anotherWall = new Wall(START_POINT, END_POINT);
            Assert.AreEqual(wall, anotherWall);
        }

        [TestMethod]
        public void TestSizeGreaterThanMaximum()
        {
            Wall wall = new Wall(new Point(25,0), new Point(50,0));
            bool result = wall.SizeGreaterThanMaximum();
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestIsVerticalWall()
        {
            Wall wall = new Wall(new Point(0, 25), new Point(0, 50));
            bool result = wall.isVerticalWall();
            Assert.IsTrue(result);
        }
    }
}
