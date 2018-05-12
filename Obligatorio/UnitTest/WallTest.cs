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
    }
}
