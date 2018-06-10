using Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    [TestClass]
    public class DecorativeColumnTest
    {
        public readonly Point POINT = new Point(10, 10);

        [TestMethod]
        public void TestCreateDecorativeColumn()
        {
            DecorativeColumn decorativeColumn = new DecorativeColumn(POINT);
            Assert.IsNotNull(decorativeColumn);
        }

        [TestMethod]
        public void TestEqual()
        {
            DecorativeColumn decorativeColumn = new DecorativeColumn(POINT);
            DecorativeColumn anotherDecorativeColumn = new DecorativeColumn(POINT);
            Assert.AreEqual(decorativeColumn, anotherDecorativeColumn);
        }
    }
}
