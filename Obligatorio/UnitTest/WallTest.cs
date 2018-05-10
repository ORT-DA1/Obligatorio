using Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class WallTest
    {
        [TestMethod]
        public void TestCreateWall()
        {
            Wall wall = new Wall();
            Assert.IsNotNull(wall);
        }
    }
}
