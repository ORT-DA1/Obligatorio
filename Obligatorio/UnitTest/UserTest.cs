﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
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
        public void TestCanABMGrids()
        {
            Assert.IsTrue(this.userTest.CanABMGrids());
        }

        [TestMethod]
        public void TestCanSeeOwnedGrids()
        {
            Assert.IsTrue(this.userTest.CanSeeOwnedGrids());
        }

        [TestMethod]
        public void TestCanVerifyInformation()
        {
           Assert.IsTrue(this.userTest.CanVerifyInformation());
        }
        [TestMethod]
        public void TestCanSeePersonalInformation()
        {
            Assert.IsTrue(this.userTest.CanSeePersonalInformation());
        }
        [TestMethod]
        public void TestCanConfigurePrices()
        {
            Assert.IsTrue(this.userTest.CanConfigurePrices());
        }

        [TestMethod]
        public void TestToString()
        {
            string username = "username";
            string name = "name";
            string surname = "surname";
            User user = new User();
            user.Username = username;
            user.Name = name;
            user.Surname = surname;
            string expectedResult = "username - name surname";
            string result = user.ToString();
            Assert.AreEqual(result, expectedResult);
        }
    }
}