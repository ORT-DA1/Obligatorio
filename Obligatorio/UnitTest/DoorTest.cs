using Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class DoorTest
    {
        [TestMethod]
        public void TestCreateDoor()
        {
            Door door = new Door();
            Assert.IsNotNull(door);
        }
    }
}