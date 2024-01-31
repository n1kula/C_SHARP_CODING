using System;
using C_SHARP_CODING;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class ClientTest
    {
        [TestMethod]
        public void FirstLastNameTest()
        {
            Client client = new Client();
            client.FirstName = "Tom";
            client.LastName = "Kowal";
            string expectedResult = "Tom Kowal";

            string actualResult = client.FirstLastName;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ValidateTest()
        {
            //Arrange
            Client client = new Client();
            client.LastName = "Kowal";
            client.Email = "emial@email.com";
            var expectedResult = true;

            //Act
            bool actualResult = client.validate();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ValidateNoLastNameTest()
        {
            //Arrange
            Client client = new Client();
            client.Email = "emial@email.com";
            var expectedResult = false;

            //Act
            bool actualResult = client.validate();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
