using System;
using Logica;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;

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
        private readonly DesignerHandler HANDLER;

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
            Designer designer = new Designer(USERNAME_OK, PASSWORD_OK, NAME_OK, SURNAME_OK, REGISTRATIONDATE_OK);

            Assert.IsTrue(designer.Username.Equals(USERNAME_OK) && designer.Password.Equals(PASSWORD_OK)
                && designer.Name.Equals(NAME_OK) && designer.Surname.Equals(SURNAME_OK)
                && designer.RegistrationDate.Equals(REGISTRATIONDATE_OK));
        }

        public Designer CreateDesigner(string username, string password, string name, string surname, DateTime registrationDate)
        {
            return new Designer(username, password, name, surname, registrationDate);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestCreateDesignerWithUsernameInvalid()
        {
            Designer designer = CreateDesigner("", PASSWORD_OK, NAME_OK, SURNAME_OK, REGISTRATIONDATE_OK);
            DesignerHandler.AddDesigner(designer);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestCreateDesignerWithPasswordInvalid()
        {
            Designer designer = CreateDesigner(USERNAME_OK, "", NAME_OK, SURNAME_OK, REGISTRATIONDATE_OK);
            DesignerHandler.AddDesigner(designer);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestCreateDesignerWithNameInvalid()
        {
            Designer designer = CreateDesigner(USERNAME_OK, PASSWORD_OK, "", SURNAME_OK, REGISTRATIONDATE_OK);
            DesignerHandler.AddDesigner(designer);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestCreateDesignerWithSurnameInvalid()
        {
            Designer designer = CreateDesigner(USERNAME_OK, PASSWORD_OK, NAME_OK, "", REGISTRATIONDATE_OK);
            DesignerHandler.AddDesigner(designer);
        }

    }
}