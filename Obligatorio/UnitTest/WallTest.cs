using Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;

namespace UnitTest
{
    [TestClass]
    public class WallTest
    {
        public readonly Domain.Entities.Point START_POINT = new Domain.Entities.Point(10, 10);
        public readonly Domain.Entities.Point END_POINT = new Domain.Entities.Point(10, 20);

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
            Wall wall = new Wall(new Domain.Entities.Point(25,0), new Domain.Entities.Point(300,0));
            bool result = wall.SizeGreaterThanMaximum();
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestIsVerticalWall()
        {
            Wall wall = new Wall(new Domain.Entities.Point(0, 25), new Domain.Entities.Point(0, 50));
            bool result = wall.isVerticalWall();
            Assert.IsTrue(result);
        }
    }
}
