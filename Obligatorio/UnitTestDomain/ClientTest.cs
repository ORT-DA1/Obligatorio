using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic;
using Domain;

namespace UnitTestDomain
{
    [TestClass]
    class ClientTest
    {
        private readonly string USERNAME_OK = "usuariotest";
        private readonly string PASSWORD_OK = "1234";
        private readonly string NAME_OK = "Joaquin";
        private readonly string SURNAME_OK = "Touris";
        private readonly string CI_OK = "5407385-0";
        private readonly DateTime REGISTRATIONDATE_OK = new DateTime(2018, 05, 28, 10, 53, 55);
        private readonly int PHONE_OK = 093535858;
        private readonly string ADDRESS_OK = "Cuareim 1818";
        private readonly ClientHandler HANDLER;

        [TestMethod]
        public void TestCreateClientWithoutParameters()
        {
            Client client = new Client();
            Assert.IsNotNull(client);
        }

        [TestMethod]
        public void TestCreateClientWithParameters()
        {
            Client client = new Client(USERNAME_OK, PASSWORD_OK, NAME_OK, SURNAME_OK, CI_OK, PHONE_OK, ADDRESS_OK, REGISTRATIONDATE_OK);

            Assert.IsTrue(client.Username.Equals(USERNAME_OK) && client.Password.Equals(PASSWORD_OK)
                && client.Name.Equals(NAME_OK) && client.Surname.Equals(SURNAME_OK) && client.IdentityCard.Equals(CI_OK)
                && client.Phone.Equals(PHONE_OK) && client.Address.Equals(ADDRESS_OK)
                && client.RegistrationDate.Equals(REGISTRATIONDATE_OK));
        }

        public Client CreateClient(string username, string password, string name, string surname, string identityCard, int phone, 
            string address, DateTime registrationDate)
        {
            return new Client(username, password, name, surname, identityCard, phone, address, registrationDate);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestCreateDesignerWithUsernameInvalid()
        {
            Client client = CreateClient("", PASSWORD_OK, NAME_OK, SURNAME_OK, CI_OK, PHONE_OK, ADDRESS_OK, REGISTRATIONDATE_OK);
            ClientHandler.AddClient(client);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestCreateDesignerWithPasswordInvalid()
        {
            Client client = CreateClient("", PASSWORD_OK, NAME_OK, SURNAME_OK, CI_OK, PHONE_OK, ADDRESS_OK, REGISTRATIONDATE_OK);
            ClientHandler.AddClient(client);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestCreateDesignerWithNameInvalid()
        {
            Client client = CreateClient("", PASSWORD_OK, NAME_OK, SURNAME_OK, CI_OK, PHONE_OK, ADDRESS_OK, REGISTRATIONDATE_OK);
            ClientHandler.AddClient(client);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestCreateDesignerWithSurnameInvalid()
        {
            Client client = CreateClient("", PASSWORD_OK, NAME_OK, SURNAME_OK, CI_OK, PHONE_OK, ADDRESS_OK, REGISTRATIONDATE_OK);
            ClientHandler.AddClient(client);
        }
    }
}
