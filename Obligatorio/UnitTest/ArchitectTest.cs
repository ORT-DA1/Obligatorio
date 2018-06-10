using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain.Data;
using Domain.Entities;
using Domain.Exceptions;

namespace UnitTest
{
    [TestClass]
    public class ArchitectTest
    {

        private readonly string USERNAME_OK = "architectTest";
        private readonly string PASSWORD_OK = "1234";
        private readonly string NAME_OK = "Miguel";
        private readonly string SURNAME_OK = "Gramajo";
        private readonly DateTime REGISTRATIONDATE_OK = new DateTime(2018, 05, 28, 10, 53, 55);
        //private readonly DesignerHandler DESIGNER_HANDLER;
        private DataStorage dataStorage;

        public ArchitectTest()
        {
            //this.DESIGNER_HANDLER = new DesignerHandler();
            this.dataStorage = DataStorage.GetStorageInstance();
        }

        [TestInitialize]
        public void TestCleanUp()
        {
            this.dataStorage.EmptyStorage();
        }

        public Architect CreateArchitect(string username, string password, string name, string surname, DateTime registrationDate)
        {
            return new Architect(username, password, name, surname, registrationDate, null);
        }

        [TestMethod]
        public void TestCanABMClients()
        {
            Architect architect = new Architect(USERNAME_OK, PASSWORD_OK, NAME_OK, SURNAME_OK, REGISTRATIONDATE_OK, null);
            Assert.IsFalse(architect.CanABMClients());
        }

        [TestMethod]
        public void TestCanABMDesigners()
        {
            Architect architect = new Architect(USERNAME_OK, PASSWORD_OK, NAME_OK, SURNAME_OK, REGISTRATIONDATE_OK, null);
            Assert.IsFalse(architect.CanABMDesigners());
        }
        [TestMethod]
        public void TestCanSeePersonalInformation()
        {
            Architect architect = new Architect(USERNAME_OK, PASSWORD_OK, NAME_OK, SURNAME_OK, REGISTRATIONDATE_OK, null);
            Assert.IsFalse(architect.CanSeePersonalInformation());
        }

        [TestMethod]
        public void TestCanABMGrids()
        {
            Architect architect = new Architect(USERNAME_OK, PASSWORD_OK, NAME_OK, SURNAME_OK, REGISTRATIONDATE_OK, null);
            Assert.IsTrue(architect.CanABMGrids());
        }
        [TestMethod]
        public void TestCanSeeOwnedGrids()
        {
            Architect architect = new Architect(USERNAME_OK, PASSWORD_OK, NAME_OK, SURNAME_OK, REGISTRATIONDATE_OK, null);
            Assert.IsFalse(architect.CanSeeOwnedGrids());
        }
        [TestMethod]
        public void TestCanVerifyInformation()
        {
            Architect architect = new Architect(USERNAME_OK, PASSWORD_OK, NAME_OK, SURNAME_OK, REGISTRATIONDATE_OK, null);
            Assert.IsFalse(architect.CanConfigurePrices());
        }
        [TestMethod]
        public void TestCanConfigurePrices()
        {
            Architect architect = new Architect(USERNAME_OK, PASSWORD_OK, NAME_OK, SURNAME_OK, REGISTRATIONDATE_OK, null);
            Assert.IsFalse(architect.CanVerifyInformation());
        }

        [TestMethod]
        public void TestCreateArchitectWithoutParameters()
        {
            Architect architect = new Architect();
            Assert.IsNotNull(architect);
        }

        [TestMethod]
        public void TestArchitectSetUsername()
        {
            Architect architect = new Architect();
            architect.Username = USERNAME_OK;
            Assert.AreEqual(architect.Username, USERNAME_OK);
        }

        [TestMethod]
        public void TestArchitectSetPassword()
        {
            Architect architect = new Architect();
            architect.Password = PASSWORD_OK;
            Assert.AreEqual(architect.Password, PASSWORD_OK);
        }

        [TestMethod]
        public void TestArchitectSetName()
        {
            Architect architect = new Architect();
            architect.Name = NAME_OK;
            Assert.AreEqual(architect.Name, NAME_OK);
        }

        [TestMethod]
        public void TestArchitectSetSurname()
        {
            Architect architect = new Architect();
            architect.Surname = SURNAME_OK;
            Assert.AreEqual(architect.Surname, SURNAME_OK);
        }


        [TestMethod]
        public void TestCreateArchitectWithParameters()
        {
            Architect architect = new Architect(USERNAME_OK, PASSWORD_OK, NAME_OK, SURNAME_OK, REGISTRATIONDATE_OK, null);

            Assert.IsTrue(architect.Username.Equals(USERNAME_OK) && architect.Password.Equals(PASSWORD_OK)
                && architect.Name.Equals(NAME_OK) && architect.Surname.Equals(SURNAME_OK)
                && architect.RegistrationDate.Equals(REGISTRATIONDATE_OK));
        }

        //[TestMethod]
        //[ExpectedException(typeof(ExceptionController))]
        //public void TestCreateArchitectWithUsernameInvalid()
        //{
        //    Architect architect = new Architect(USERNAME_OK, PASSWORD_OK, NAME_OK, SURNAME_OK, REGISTRATIONDATE_OK, null);
        //    //DESIGNER_HANDLER.Add(designer);
        //}

        //[TestMethod]
        //[ExpectedException(typeof(ExceptionController))]
        //public void TestCreateDesignerWithPasswordInvalid()
        //{
        //    Designer designer = CreateDesigner(USERNAME_OK, "", NAME_OK, SURNAME_OK, REGISTRATIONDATE_OK);
        //    DESIGNER_HANDLER.Add(designer);
        //}

        //[TestMethod]
        //[ExpectedException(typeof(ExceptionController))]
        //public void TestCreateDesignerWithNameInvalid()
        //{
        //    Designer designer = CreateDesigner(USERNAME_OK, PASSWORD_OK, "", SURNAME_OK, REGISTRATIONDATE_OK);
        //    DESIGNER_HANDLER.Add(designer);
        //}

        //[TestMethod]
        //[ExpectedException(typeof(ExceptionController))]
        //public void TestCreateDesignerWithSurnameInvalid()
        //{
        //    Designer designer = CreateDesigner(USERNAME_OK, PASSWORD_OK, NAME_OK, "", REGISTRATIONDATE_OK);
        //    DESIGNER_HANDLER.Add(designer);
        //}

    }
}
