﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    [TestClass]
    public class WallBeamTest
    {
        [TestMethod]
        public void TestCreateWall()
        {
            Wall wall = new Wall();
            Assert.IsNotNull(wall);
        }
    }
}
