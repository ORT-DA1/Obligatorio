using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain.Entities;
using Domain.Data;


namespace UnitTest
{
    [TestClass]
    public class AdministratorTest
    {
        private DataStorage storage;

        public AdministratorTest()
        {
            this.storage = DataStorage.GetStorageInstance();
        }

        [TestMethod]
        public void TestCreateAdministratorWithoutParameters()
        {
            Administrator administrator = new Administrator();
            Assert.IsNotNull(administrator);
        }

        [TestMethod]
        public void TestCanSeeOwnedGrids()
        {
            Assert.IsFalse(this.storage.Administrator.CanSeeOwnedGrids());
        }
        [TestMethod]
        public void TestCanABMGrids()
        {
            Assert.IsFalse(this.storage.Administrator.CanABMGrids());
        }
        [TestMethod]
        public void TestCanVerifyInformation()
        {
            Assert.IsFalse(this.storage.Administrator.CanVerifyInformation());
        }
        [TestMethod]
        public void TestCanConfigurePrices()
        {
            Assert.IsTrue(this.storage.Administrator.CanConfigurePrices());
        }
        [TestMethod]
        public void TestCanSeePersonalInformation()
        {
            Assert.IsFalse(storage.Administrator.CanSeePersonalInformation());
        }
    }
}
