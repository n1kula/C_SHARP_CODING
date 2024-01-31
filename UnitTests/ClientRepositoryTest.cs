using System;
using C_SHARP_CODING;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class ClientRepositoryTest
    {
        [TestMethod]
        public void GetClient()
        {
            //Arrange
            var clientRepository = new ClientRepository();
            var expectedResult = new Client(1)
            {
                Email = "email@email.com",
                FirstName = "tom",
                LastName = "kowalski"
            };

            //Act
            var currentResult = clientRepository.getData(1);

            //Assert
            Assert.AreEqual(expectedResult.ClientId, currentResult.ClientId);
            Assert.AreEqual(expectedResult.Email, currentResult.Email);
            Assert.AreEqual(expectedResult.FirstName, currentResult.FirstName);
            Assert.AreEqual(expectedResult.LastName, currentResult.LastName);
        }
    }
}
