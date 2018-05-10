using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class WindowTest
    {
        [TestMethod]
        public void TestCreateWindow()
        {
            Window window = new Window();
            Assert.IsNotNull(window);
        }
    }
}