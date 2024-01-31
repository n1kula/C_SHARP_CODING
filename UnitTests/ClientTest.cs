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

            var client2 = new Client(100);
            client2.Email = "emial@email.com";
            var expectedResult2 = false;

            //Act
            bool actualResult = client.validate();
            bool actualResult2 = client2.validate();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
            Assert.AreEqual(expectedResult2, actualResult2);
        }
    }
}
