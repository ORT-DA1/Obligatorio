using Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;

namespace UnitTest
{
    [TestClass]
    public class WallBeamTest
    {
        public readonly Domain.Entities.Point POINT = new Domain.Entities.Point(10, 10);

        [TestMethod]
        public void TestCreateWallBeam()
        {
            WallBeam wallBeam = new WallBeam(POINT);
            Assert.IsNotNull(wallBeam);
        }

        [TestMethod]
        public void TestEqual()
        {
            WallBeam wallBeam = new WallBeam(POINT);
            WallBeam anotherWallBeam = new WallBeam(POINT);
            Assert.AreEqual(wallBeam, anotherWallBeam);
        }
    }
}
