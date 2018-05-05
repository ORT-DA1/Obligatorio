using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;
using System;

namespace UnitTestDomain
{
    [TestClass]
    public class UserTest
    {
        private readonly string USERNAME_OK = "usuariotest";
        private readonly string PASSWORD_OK = "1234";
        private readonly string NAME_OK = "Pablo";
        private readonly string SURNAME_OK = "Pereira";
        private readonly string CI_OK = "5407385-0";
        private readonly DateTime REGISTRATIONDATE_OK = new DateTime(2018,05,28,10,53,55);
        private readonly int PHONE_OK = 093535858;
        private readonly string ADDRESS_OK = "Cuareim 1818";

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
            Administrator administrator = new Administrator(USERNAME_OK, PASSWORD_OK, NAME_OK, SURNAME_OK
                , REGISTRATIONDATE_OK);

            Assert.IsTrue(administrator.Username.Equals(USERNAME_OK) && administrator.Password.Equals(PASSWORD_OK) 
                && administrator.Name.Equals(NAME_OK) && administrator.Surname.Equals(SURNAME_OK) 
                && administrator.RegistrationDate.Equals(REGISTRATIONDATE_OK));
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
            Administrator administrator = new Administrator(USERNAME_OK, PASSWORD_OK, NAME_OK, SURNAME_OK, REGISTRATIONDATE_OK);
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
            Client client = new Client(USERNAME_OK, PASSWORD_OK, NAME_OK, SURNAME_OK, CI_OK, PHONE_OK, ADDRESS_OK, REGISTRATIONDATE_OK);
            Assert.IsNotNull(client);
        }

    }
}
