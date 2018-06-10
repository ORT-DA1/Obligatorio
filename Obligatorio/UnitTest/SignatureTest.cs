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
    public class SignatureTest
    {
        private readonly string USERNAME_OK = "architectTest";
        private readonly string PASSWORD_OK = "1234";
        private readonly string NAME_OK = "Miguel";
        private readonly string SURNAME_OK = "Gramajo";
        private readonly DateTime REGISTRATIONDATE_OK = new DateTime(2018, 05, 28, 10, 53, 55);

        [TestMethod]
        public void TestCreateSignature()
        {
            DateTime date = new DateTime(2018, 05, 28, 10, 53, 55);
            Architect architect = new Architect(USERNAME_OK, PASSWORD_OK, NAME_OK, SURNAME_OK, REGISTRATIONDATE_OK, null);

            Signature signature = new Signature(architect, date);
            Assert.IsNotNull(signature);
        }

        [TestMethod]
        public void TestSignatureSetArchitect()
        {
            Architect architect = new Architect(USERNAME_OK, PASSWORD_OK, NAME_OK, SURNAME_OK, REGISTRATIONDATE_OK, null);
            Signature signature = new Signature();
            signature.Architect = architect;
            Assert.AreEqual(signature.Architect, architect);
        }

        [TestMethod]
        public void TestSignatureSetDate()
        {
            Signature signature = new Signature();
            signature.Date = REGISTRATIONDATE_OK;
            Assert.AreEqual(signature.Date, REGISTRATIONDATE_OK);
        }
    }
}
