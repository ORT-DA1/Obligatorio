using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    [TestClass]
    public class GridTest
    {
        [TestMethod]
        public void TestCreateGridWithoutParameters()
        {
            Grid grid = new Grid();
            Assert.IsNotNull(grid);
        }

        [TestMethod]
        public void TestCreateGridWithParameters()
        {
            Grid grid = new Grid();
            Assert.IsNotNull(grid);
        }
    }
}
