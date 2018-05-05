using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;
using System;

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

        [TestMethod]
        public void TestCreateAdministratorWithParameters()
        {
            DateTime registrationDate = DateTime.Now;
            Administrator administrator = new Administrator("admin","admin","Pablo","Pereira",registrationDate);
            Assert.IsNotNull(administrator);
        }

        [TestMethod]
        public void TestCreateDesignerWithoutParameters()
        {
            Designer designer = new Designer();
            Assert.IsNotNull(designer);
        }

        [TestMethod]
        public void TestCreateDesignerWithParameters()
        {
            DateTime registrationDate = DateTime.Now;
            Administrator administrator = new Administrator("designer", "designer", "Joaquin", "Touris", registrationDate);
            Assert.IsNotNull(administrator);
        }

        [TestMethod]
        public void TestCreateClientWithoutParameters()
        {
            Client client = new Client();
            Assert.IsNotNull(client);
        }

        [TestMethod]
        public void TestCreateClientWithParameters()
        {
            DateTime registrationDate = DateTime.Now;
            Client client = new Client("client", "client", "Pablo", "Pereira", "5407350-0", 093535858, "Cuareim 1558", registrationDate);
            Assert.IsNotNull(client);
        }

    }
}
