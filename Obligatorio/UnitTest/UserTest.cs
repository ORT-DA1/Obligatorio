using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
namespace UnitTest
{
    [TestClass]
    public class UserTest
    {
        private readonly string USERNAME_OK = "usuariotest";
        private readonly string PASSWORD_OK = "1234";
        private readonly string NAME_OK = "Pablo";
        private readonly string SURNAME_OK = "Pereira";
        private readonly DateTime REGISTRATIONDATE_OK = new DateTime(2018, 05, 28, 10, 53, 55);
        private User userTest;
        public UserTest()
        {
            this.userTest = new User(USERNAME_OK, PASSWORD_OK, NAME_OK, SURNAME_OK, REGISTRATIONDATE_OK, null);
        }

        [TestMethod]
        public void TestCanABMClients() 
        {
            Assert.IsTrue(this.userTest.CanABMClients());
        }

        [TestMethod]
        public void TestCanABMDesigners()
        {
            Assert.IsTrue(this.userTest.CanABMDesigners());
        }
        [TestMethod]
        public void TestCanCreateGrid()
        {
            Assert.IsTrue(userTest.CanCreateGrid());
        }
        [TestMethod]
        public void TestCanSeeOwnedGrids()
        {
            Assert.IsTrue(this.userTest.CanSeeOwnedGrids());
        }
    }
}