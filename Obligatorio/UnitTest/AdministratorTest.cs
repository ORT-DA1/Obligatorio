using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Logic;
using Domain.Interface;
using Domain.Entities;
using Domain.Data;
using Domain.Exceptions;


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
        public void TestCanSeeOwnedGrids()
        {
            Assert.IsFalse(this.storage.Administrator.CanSeeOwnedGrids());
        }
        [TestMethod]
        public void TestCanCreateGrid()
        {
            Assert.IsFalse(this.storage.Administrator.CanCreateGrid());
        }
    }
}
