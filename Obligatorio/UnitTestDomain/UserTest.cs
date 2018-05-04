using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;

namespace UnitTestDomain
{
    [TestClass]
    public class UserTest
    {
        [TestMethod]
        public void TestCreateAdministratorWithoutParameters()
        {
            Administrator administrator = new Administrator();
            Assert.IsNotNull(administrator);
        }

    }
}
