using Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;

namespace UnitTest
{
    [TestClass]
    public class DoorTest
    {
        private readonly float HIGH;
        private readonly float WIDTH;
        private readonly Domain.Entities.Point START_POINT;
        private readonly Domain.Entities.Point END_POINT;
        private readonly string NAME;
        private readonly string SENSE;
        private readonly int direction;

        public DoorTest()
        {
            this.START_POINT = new Domain.Entities.Point(25,25);
            this.END_POINT = new Domain.Entities.Point(25, 25);
            this.SENSE = "vertical";
            this.NAME = "defecto";
            this.direction = 0;
            this.WIDTH = 0.85f;
            this.HIGH = 2.20f;
        }

        [TestMethod]
        public void TestCreateDoor()
        {
            Door door = new Door();
            Assert.IsNotNull(door);
        }

        [TestMethod]
        public void TestCreateDoorWithAllParametersIncludingWidthAndHigh()
        {
            Door door = new Door(START_POINT, END_POINT, SENSE, WIDTH, HIGH, NAME);
            Assert.IsTrue(door.StartPoint.X == START_POINT.X && door.StartPoint.Y == START_POINT.Y && door.sense.Equals(SENSE)
                 && door.width == WIDTH && door.high == HIGH && door.name.Equals(NAME));
        }
    }
}