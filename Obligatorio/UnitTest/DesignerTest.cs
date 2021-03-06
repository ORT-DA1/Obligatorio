﻿using System;
using Domain.Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain.Entities;
using Domain.Exceptions;
using Domain.Data;

namespace UnitTest
{
    [TestClass]
    public class DesignerTest
    {
        private readonly string USERNAME_OK = "usuariotest";
        private readonly string PASSWORD_OK = "1234";
        private readonly string NAME_OK = "Pablo";
        private readonly string SURNAME_OK = "Pereira";
        private readonly DateTime REGISTRATIONDATE_OK = new DateTime(2018, 05, 28, 10, 53, 55);
        private readonly DesignerHandler DESIGNER_HANDLER;
        private DataStorage dataStorage;

        public DesignerTest()
        {
            this.DESIGNER_HANDLER = new DesignerHandler();
            this.dataStorage = DataStorage.GetStorageInstance();
        }

        /*[TestInitialize]
        public void TestCleanUp()
        {
            this.dataStorage.EmptyStorage();
        }*/

        public Designer CreateDesigner(string username, string password, string name, string surname, DateTime registrationDate)
        {
            return new Designer(username, password, name, surname, registrationDate, null);
        }


        [TestMethod]
        public void TestCanABMClients()
        {
            Designer designer = new Designer(USERNAME_OK, PASSWORD_OK, NAME_OK, SURNAME_OK, REGISTRATIONDATE_OK, null);
            Assert.IsFalse(designer.CanABMClients());
        }

        [TestMethod]
        public void TestCanABMDesigners()
        {
            Designer designer = new Designer(USERNAME_OK, PASSWORD_OK, NAME_OK, SURNAME_OK, REGISTRATIONDATE_OK, null);
            Assert.IsFalse(designer.CanABMDesigners());
        }
        [TestMethod]
        public void TestCanSeePersonalInformation()
        {
            Designer designer = new Designer(USERNAME_OK, PASSWORD_OK, NAME_OK, SURNAME_OK, REGISTRATIONDATE_OK, null);
            Assert.IsFalse(designer.CanSeePersonalInformation());
        }

        [TestMethod]
        public void TestCanABMGrids()
        {
            Designer designer = new Designer(USERNAME_OK, PASSWORD_OK, NAME_OK, SURNAME_OK, REGISTRATIONDATE_OK, null);
            Assert.IsTrue(designer.CanABMGrids());
        }
        [TestMethod]
        public void TestCanSeeOwnedGrids()
        {
            Designer designer = new Designer(USERNAME_OK, PASSWORD_OK, NAME_OK, SURNAME_OK, REGISTRATIONDATE_OK, null);
            Assert.IsFalse(designer.CanSeeOwnedGrids());
        }
        [TestMethod]
        public void TestCanVerifyInformation()
        {
            Designer designer = new Designer(USERNAME_OK, PASSWORD_OK, NAME_OK, SURNAME_OK, REGISTRATIONDATE_OK, null);
            Assert.IsFalse(designer.CanConfigurePrices());
        }
        [TestMethod]
        public void TestCanConfigurePrices()
        {
            Designer designer = new Designer(USERNAME_OK, PASSWORD_OK, NAME_OK, SURNAME_OK, REGISTRATIONDATE_OK, null);
            Assert.IsFalse(designer.CanVerifyInformation());
        }

        [TestMethod]
        public void TestAddDesigner()
        {
            Designer designer = new Designer(USERNAME_OK, PASSWORD_OK, NAME_OK, SURNAME_OK, REGISTRATIONDATE_OK, null);
            DESIGNER_HANDLER.Add(designer);
            Assert.IsTrue(DESIGNER_HANDLER.boolExist(designer));
        }

        [TestMethod]
        public void TestDeleteDesigner()
        {
            Designer designer = new Designer(USERNAME_OK, PASSWORD_OK, NAME_OK, SURNAME_OK, REGISTRATIONDATE_OK, null);
            DESIGNER_HANDLER.Add(designer);
            DESIGNER_HANDLER.Delete(designer);
            Assert.IsFalse(DESIGNER_HANDLER.boolExist(designer));
        }

        [TestMethod]
        public void TestModifyDesignerNameAndSurname()
        {

            Designer designer = new Designer(USERNAME_OK, PASSWORD_OK, NAME_OK, SURNAME_OK, REGISTRATIONDATE_OK, null);
            DESIGNER_HANDLER.Add(designer);
            Designer modifiedDesigner = DESIGNER_HANDLER.GetByUsernameAndPassword(USERNAME_OK, PASSWORD_OK);
            modifiedDesigner.Name = "Diego";
            modifiedDesigner.Surname = "Nov";
            DESIGNER_HANDLER.Modify(modifiedDesigner);
            Designer designerToVerify = DESIGNER_HANDLER.Get(modifiedDesigner);
            Assert.IsTrue(designerToVerify.Name.Equals("Diego") && designerToVerify.Surname.Equals("Nov"));
        }

        [TestMethod]
        public void TestCreateDesignerWithoutParameters()
        {
            Designer designer = new Designer();
            Assert.IsNotNull(designer);
        }

        [TestMethod]
        public void TestDesignerSetUsername()
        {
            Designer designer = new Designer();
            designer.Username = USERNAME_OK;
            Assert.AreEqual(designer.Username, USERNAME_OK);
        }

        [TestMethod]
        public void TestDesignerSetPassword()
        {
            Designer designer = new Designer();
            designer.Password = PASSWORD_OK;
            Assert.AreEqual(designer.Password, PASSWORD_OK);
        }

        [TestMethod]
        public void TestDesignerSetName()
        {
            Designer designer = new Designer();
            designer.Name = NAME_OK;
            Assert.AreEqual(designer.Name, NAME_OK);
        }

        [TestMethod]
        public void TestDesignerSetSurname()
        {
            Designer designer = new Designer();
            designer.Surname = SURNAME_OK;
            Assert.AreEqual(designer.Surname, SURNAME_OK);
        }


        [TestMethod]
        public void TestCreateDesignerWithParameters()
        {
            Designer designer = new Designer(USERNAME_OK, PASSWORD_OK, NAME_OK, SURNAME_OK, REGISTRATIONDATE_OK, null);

            Assert.IsTrue(designer.Username.Equals(USERNAME_OK) && designer.Password.Equals(PASSWORD_OK)
                && designer.Name.Equals(NAME_OK) && designer.Surname.Equals(SURNAME_OK)
                && designer.RegistrationDate.Equals(REGISTRATIONDATE_OK));
        }

        [TestMethod]
        [ExpectedException(typeof(ExceptionController))]
        public void TestCreateDesignerWithUsernameInvalid()
        {
            Designer designer = CreateDesigner("", PASSWORD_OK, NAME_OK, SURNAME_OK, REGISTRATIONDATE_OK);
            DESIGNER_HANDLER.Add(designer);
        }

        [TestMethod]
        [ExpectedException(typeof(ExceptionController))]
        public void TestCreateDesignerWithPasswordInvalid()
        {
            Designer designer = CreateDesigner(USERNAME_OK, "", NAME_OK, SURNAME_OK, REGISTRATIONDATE_OK);
            DESIGNER_HANDLER.Add(designer);
        }

        [TestMethod]
        [ExpectedException(typeof(ExceptionController))]
        public void TestCreateDesignerWithNameInvalid()
        {
            Designer designer = CreateDesigner(USERNAME_OK, PASSWORD_OK, "", SURNAME_OK, REGISTRATIONDATE_OK);
            DESIGNER_HANDLER.Add(designer);
        }

        [TestMethod]
        [ExpectedException(typeof(ExceptionController))]
        public void TestCreateDesignerWithSurnameInvalid()
        {
            Designer designer = CreateDesigner(USERNAME_OK, PASSWORD_OK, NAME_OK, "", REGISTRATIONDATE_OK);
            DESIGNER_HANDLER.Add(designer);
        }

    }
}