using Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class WallBeamTest
    {
        [TestMethod]
        public void TestCreateWall()
        {
            WallBeam wallBeam = new WallBeam();
            Assert.IsNotNull(wallBeam);
        }
    }
}
