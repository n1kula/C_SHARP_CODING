using System;
using System.Collections.Generic;
using System.Net;
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

        [TestMethod]
        public void GetClientWithAddresses()
        {
            //Arrange
            var clientRepository = new ClientRepository();
            var expectedResult = new Client(1)
            {
                Email = "email@email.com",
                FirstName = "tom",
                LastName = "kowalski",
                AddressList = new List<Address>() 
                {
                    new Address(1)
                    {
                        AddressType = 1,
                        Street = "testowa",
                        City = "Warszawa",
                        PostalCode = "00-000",
                        Country = "Polska"
                    },
                    new Address(2)
                    {
                        AddressType = 2,
                        Street = "Jakas",
                        City = "Krakow",
                        PostalCode = "22-222",
                        Country = "Polska"
                    }
                }
            };

            //Act
            var currentResult = clientRepository.getData(1);

            //Assert
            Assert.AreEqual(expectedResult.ClientId, currentResult.ClientId);
            Assert.AreEqual(expectedResult.Email, currentResult.Email);
            Assert.AreEqual(expectedResult.FirstName, currentResult.FirstName);
            Assert.AreEqual(expectedResult.LastName, currentResult.LastName);

            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual(expectedResult.AddressList[i].AddressType, currentResult.AddressList[i].AddressType);
                Assert.AreEqual(expectedResult.AddressList[i].City, currentResult.AddressList[i].City);
            }
        }
    }
}
