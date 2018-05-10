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


namespace UnitTest
{
    [TestClass]
    public class ClientTest
    {
        private readonly string USERNAME_OK = "usuariotest";
        private readonly string PASSWORD_OK = "1234";
        private readonly string NAME_OK = "Joaquin";
        private readonly string SURNAME_OK = "Touris";
        private readonly string CI_OK = "5407385-0";
        private readonly DateTime REGISTRATIONDATE_OK = new DateTime(2018, 05, 28, 10, 53, 55);
        private readonly int PHONE_OK = 093535858;
        private readonly string ADDRESS_OK = "Cuareim 1818";
        private readonly IUserHandler<Client> CLIENT_HANDLER;
        private DataStorage dataStorage;

        public ClientTest()
        {
            this.CLIENT_HANDLER = new ClientHandler();
            this.dataStorage = DataStorage.GetStorageInstance();
        }

        [TestMethod]
        public void TestCreateClientWithoutParameters()
        {
            Client client = new Client();
            Assert.IsNotNull(client);
        }

        [TestMethod]
        public void TestClientSetUsername()
        {
            Client client = new Client();
            client.Username = USERNAME_OK;
            Assert.AreEqual(client.Username, USERNAME_OK);
        }

        [TestMethod]
        public void TestClientSetPassword()
        {
            Client client = new Client();
            client.Password = PASSWORD_OK;
            Assert.AreEqual(client.Password, PASSWORD_OK);
        }

        [TestMethod]
        public void TestClientSetName()
        {
            Client client = new Client();
            client.Name = NAME_OK;
            Assert.AreEqual(client.Name, NAME_OK);
        }

        [TestMethod]
        public void TestClientSetSurname()
        {
            Client client = new Client();
            client.Surname = SURNAME_OK;
            Assert.AreEqual(client.Surname, SURNAME_OK);
        }

        [TestMethod]
        public void TestClientSetIdentityCard()
        {
            Client client = new Client();
            client.IdentityCard = CI_OK;
            Assert.AreEqual(client.IdentityCard, CI_OK);
        }

        [TestMethod]
        public void TestClientSetPhone()
        {
            Client client = new Client();
            client.Phone = PHONE_OK;
            Assert.AreEqual(client.Phone, PHONE_OK);
        }

        [TestMethod]
        public void TestClientSetAddress()
        {
            Client client = new Client();
            client.Address = ADDRESS_OK;
            Assert.AreEqual(client.Address, ADDRESS_OK);
        }

        [TestMethod]
        public void TestCreateClientWithParameters()
        {
            Client client = new Client(USERNAME_OK, PASSWORD_OK, NAME_OK, SURNAME_OK, CI_OK, PHONE_OK, ADDRESS_OK, REGISTRATIONDATE_OK, null);

            Assert.IsTrue(client.Username.Equals(USERNAME_OK) && client.Password.Equals(PASSWORD_OK)
                && client.Name.Equals(NAME_OK) && client.Surname.Equals(SURNAME_OK) && client.IdentityCard.Equals(CI_OK)
                && client.Phone.Equals(PHONE_OK) && client.Address.Equals(ADDRESS_OK)
                && client.RegistrationDate.Equals(REGISTRATIONDATE_OK));
        }

        [TestMethod]
        public void TestDeleteClient()
        {
            Client client = new Client(USERNAME_OK, PASSWORD_OK, NAME_OK, SURNAME_OK, CI_OK, PHONE_OK, ADDRESS_OK, REGISTRATIONDATE_OK, null);
            CLIENT_HANDLER.Add(client);
            CLIENT_HANDLER.Delete(client);
            Assert.IsFalse(dataStorage.Clients.Contains(client));
        }



    //    [TestMethod]
    //    [ExpectedException(typeof(Exception))]
    //    public void TestCreateClientWithUsernameInvalid()
    //    {
    //        Client client = new Client("", PASSWORD_OK, NAME_OK, SURNAME_OK, CI_OK, PHONE_OK, ADDRESS_OK, REGISTRATIONDATE_OK, null);
    //        CLIENT_HANDLER.Add(client);
    //    }

    //    [TestMethod]
    //    [ExpectedException(typeof(Exception))]
    //    public void TestCreateClientWithPasswordInvalid()
    //    {
    //        Client client = new Client("", PASSWORD_OK, NAME_OK, SURNAME_OK, CI_OK, PHONE_OK, ADDRESS_OK, REGISTRATIONDATE_OK, null);
    //        CLIENT_HANDLER.Add(client);
    //    }

    //    [TestMethod]
    //    [ExpectedException(typeof(Exception))]
    //    public void TestCreateClientWithNameInvalid()
    //    {
    //        Client client = new Client("", PASSWORD_OK, NAME_OK, SURNAME_OK, CI_OK, PHONE_OK, ADDRESS_OK, REGISTRATIONDATE_OK, null);
    //        CLIENT_HANDLER.Add(client);
    //    }

    //    [TestMethod]
    //    [ExpectedException(typeof(Exception))]
    //    public void TestCreateClientWithSurnameInvalid()
    //    {
    //        Client client = new Client("", PASSWORD_OK, NAME_OK, SURNAME_OK, CI_OK, PHONE_OK, ADDRESS_OK, REGISTRATIONDATE_OK, null);
    //        CLIENT_HANDLER.Add(client);
    //    }
    }
}