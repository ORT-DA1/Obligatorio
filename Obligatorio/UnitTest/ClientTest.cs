﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Domain.Logic;
using Domain.Interface;
using Domain.Entities;
using Domain.Data;
using Domain.Exceptions;
using Domain.Repositories;

namespace UnitTest
{
    [TestClass]
    public class ClientTest
    {
        private readonly string USERNAME_OK = "usuariotest";
        private readonly string PASSWORD_OK = "1234";
        private readonly string NAME_OK = "Joaquin";
        private readonly string SURNAME_OK = "Touris";
        private readonly string CI_OK = "45688334";
        private readonly DateTime REGISTRATIONDATE_OK = new DateTime(2018, 05, 28, 10, 53, 55);
        private readonly DateTime LASTACCESS_OK = DateTime.Now;
        private readonly string PHONE_OK = "093535858";
        private readonly string ADDRESS_OK = "Cuareim 1818";
        private readonly IUserHandler<Client> CLIENT_HANDLER;

        public ClientTest()
        {
            this.CLIENT_HANDLER = new ClientHandler();
        }

        [TestInitialize]
        public void TestCleanUp()
        {
            //dataStorage.EmptyStorage();
        }

        [TestMethod]
        public void TestCanABMClients()
        {
            Client client = new Client(USERNAME_OK, PASSWORD_OK, NAME_OK, SURNAME_OK, CI_OK, PHONE_OK, ADDRESS_OK, REGISTRATIONDATE_OK, null);
            Assert.IsFalse(client.CanABMClients());
        }

        [TestMethod]
        public void TestCanABMDesigners()
        {
            Client client = new Client(USERNAME_OK, PASSWORD_OK, NAME_OK, SURNAME_OK, CI_OK, PHONE_OK, ADDRESS_OK, REGISTRATIONDATE_OK, null);
            Assert.IsFalse(client.CanABMDesigners());
        }
        [TestMethod]
        public void TestCanABMGrids()
        {
            Client client = new Client(USERNAME_OK, PASSWORD_OK, NAME_OK, SURNAME_OK, CI_OK, PHONE_OK, ADDRESS_OK, REGISTRATIONDATE_OK, null);
            Assert.IsFalse(client.CanABMGrids());
        }

        [TestMethod]
        public void TestCanVerifyInformation()
        {
            Client client = new Client(USERNAME_OK, PASSWORD_OK, NAME_OK, SURNAME_OK, CI_OK, PHONE_OK, ADDRESS_OK, REGISTRATIONDATE_OK, null);
            Assert.IsTrue(client.CanVerifyInformation());
        }
        [TestMethod]
        public void TestCanConfigurePrices()
        {
            Client client = new Client(USERNAME_OK, PASSWORD_OK, NAME_OK, SURNAME_OK, CI_OK, PHONE_OK, ADDRESS_OK, REGISTRATIONDATE_OK, null);
            Assert.IsFalse(client.CanConfigurePrices());
        }
        [TestMethod]
        public void TestCanSeePersonalInformation()
        {
            Client client = new Client(USERNAME_OK, PASSWORD_OK, NAME_OK, SURNAME_OK, CI_OK, PHONE_OK, ADDRESS_OK, REGISTRATIONDATE_OK, null);
            Assert.IsTrue(client.CanSeePersonalInformation());
        }
        [TestMethod]
        public void TestCanVerifyInformationWithLastAccessNotNull()
        {
            Client client = new Client(USERNAME_OK, PASSWORD_OK, NAME_OK, SURNAME_OK, CI_OK, PHONE_OK, ADDRESS_OK, REGISTRATIONDATE_OK, LASTACCESS_OK);
            Assert.IsFalse(client.CanVerifyInformation());
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
            Assert.IsFalse(CLIENT_HANDLER.boolExist(client));
        }
        
        [TestMethod]
        public void TestAddClientOk()
        {
            Client client = new Client(USERNAME_OK, PASSWORD_OK, NAME_OK, SURNAME_OK, CI_OK, PHONE_OK, ADDRESS_OK, REGISTRATIONDATE_OK, null);
            CLIENT_HANDLER.Add(client);
            Assert.IsTrue(CLIENT_HANDLER.boolExist(client)); 
        }

        [TestMethod]
        public void TestModifyClientUserNamePassword()
        {
            Client client = new Client(USERNAME_OK, PASSWORD_OK, NAME_OK, SURNAME_OK, CI_OK, PHONE_OK, ADDRESS_OK, REGISTRATIONDATE_OK, null);
            CLIENT_HANDLER.Add(client);
            Client modifiedClient = CLIENT_HANDLER.GetByUsernameAndPassword(USERNAME_OK, PASSWORD_OK);
            modifiedClient.Username = "username2";
            modifiedClient.Password = "password";
            CLIENT_HANDLER.Modify(modifiedClient);
            Client clientToVerify = CLIENT_HANDLER.Get(modifiedClient);
            Assert.IsTrue(clientToVerify.Username.Equals("username2") && clientToVerify.Password.Equals("password"));
        }

        [TestMethod]
        public void TestModifyClientNameAndSurnameAndID()
        {
            Client client = new Client(USERNAME_OK, PASSWORD_OK, NAME_OK, SURNAME_OK, CI_OK, PHONE_OK, ADDRESS_OK, REGISTRATIONDATE_OK, null);
            CLIENT_HANDLER.Add(client);
            Client modifiedClient = CLIENT_HANDLER.GetByUsernameAndPassword(USERNAME_OK,PASSWORD_OK);
            modifiedClient.Name = "Diego";
            modifiedClient.Surname = "Nov";
            CLIENT_HANDLER.Modify(modifiedClient);
            Client clientToVerify = CLIENT_HANDLER.Get(modifiedClient);
            Assert.IsTrue(clientToVerify.Name.Equals("Diego") && clientToVerify.Surname.Equals("Nov"));
        }

        [TestMethod]
        [ExpectedException(typeof(ExceptionController))]
        public void TestCreateClientWithExistingUsername()
        {
            Client client = new Client("ClientTest", PASSWORD_OK, NAME_OK, SURNAME_OK, CI_OK, PHONE_OK, ADDRESS_OK, REGISTRATIONDATE_OK, null);
            CLIENT_HANDLER.Add(client);
            Client anotherClient = new Client("ClientTest", PASSWORD_OK, NAME_OK, SURNAME_OK, "12345712", PHONE_OK, ADDRESS_OK, REGISTRATIONDATE_OK, null);
            CLIENT_HANDLER.Add(anotherClient);
        }

        [TestMethod]
        [ExpectedException(typeof(ExceptionController))]
        public void TestCreateClientWithExistingID()
        {
            Client client = new Client(USERNAME_OK, PASSWORD_OK, NAME_OK, SURNAME_OK, CI_OK, PHONE_OK, ADDRESS_OK, REGISTRATIONDATE_OK, null);
            CLIENT_HANDLER.Add(client);
            Client anotherClient = new Client("ClientTest", PASSWORD_OK, NAME_OK, SURNAME_OK, CI_OK, PHONE_OK, ADDRESS_OK, REGISTRATIONDATE_OK, null);
            CLIENT_HANDLER.Add(anotherClient);
        }

        [TestMethod]
        [ExpectedException(typeof(ExceptionController))]
        public void TestCreateClientWithUsernameInvalid()
        {
            Client client = new Client("", PASSWORD_OK, NAME_OK, SURNAME_OK, CI_OK, PHONE_OK, ADDRESS_OK, REGISTRATIONDATE_OK, null);
            CLIENT_HANDLER.Add(client);
        }

        [TestMethod]
        [ExpectedException(typeof(ExceptionController))]
        public void TestCreateClientWithPasswordInvalid()
        {
            Client client = new Client("", PASSWORD_OK, NAME_OK, SURNAME_OK, CI_OK, PHONE_OK, ADDRESS_OK, REGISTRATIONDATE_OK, null);
            CLIENT_HANDLER.Add(client);
        }

        [TestMethod]
        [ExpectedException(typeof(ExceptionController))]
        public void TestCreateClientWithNameInvalid()
        {
            Client client = new Client("", PASSWORD_OK, NAME_OK, SURNAME_OK, CI_OK, PHONE_OK, ADDRESS_OK, REGISTRATIONDATE_OK, null);
            CLIENT_HANDLER.Add(client);
        }

        [TestMethod]
        [ExpectedException(typeof(ExceptionController))]
        public void TestCreateClientWithSurnameInvalid()
        {
            Client client = new Client("", PASSWORD_OK, NAME_OK, SURNAME_OK, CI_OK, PHONE_OK, ADDRESS_OK, REGISTRATIONDATE_OK, null);
            CLIENT_HANDLER.Add(client);

        }

        [TestMethod]
        public void TestEqualsWithName()
        {
            Client client = new Client(USERNAME_OK, PASSWORD_OK, NAME_OK, SURNAME_OK, CI_OK, PHONE_OK, ADDRESS_OK, REGISTRATIONDATE_OK, null);
            Assert.IsFalse(client.Equals(USERNAME_OK));
        }

        [TestMethod]
        public void TestEqualClient()
        {
            Client client = new Client(USERNAME_OK, PASSWORD_OK, NAME_OK, SURNAME_OK, CI_OK, PHONE_OK, ADDRESS_OK, REGISTRATIONDATE_OK, null);
            Client otherClient = new Client(USERNAME_OK, PASSWORD_OK, "Pedro", "Filgueira", CI_OK, PHONE_OK, ADDRESS_OK , REGISTRATIONDATE_OK, null);
            Assert.IsTrue(client.Equals(otherClient));
        }
        
    }
}