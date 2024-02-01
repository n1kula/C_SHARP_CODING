using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using C_SHARP_CODING;
using System.Net;
using System.Collections.Generic;

namespace UnitTests
{
    [TestClass]
    public class OrderRepositoryTest
    {
        [TestMethod]
        public void getData()
        {
            //Arrange
            var orderRepository = new OrderRepository();
            var expected = new Order(3)
            {
                OrderDate = new DateTimeOffset(2024, 1, 31, 10, 00, 00, new TimeSpan(7, 0, 0))
            };
            //Act
            var current = orderRepository.getData(3);

            //Assert
            Assert.AreEqual(expected.OrderId, current.OrderId);
            Assert.AreEqual(expected.OrderDate, current.OrderDate);
        }

        [TestMethod]
        public void getOrderToShowData()
        {
            //Arrange
            var orderRepository = new OrderRepository();
            var expected = new ShowOrder()
            {
                FirstName = "Tomasz",
                LastName =  "Nowak",
                OrderDate = new DateTimeOffset(2024, 1, 31, 10, 00, 00, new TimeSpan(7, 0, 0)),
                DeliveryAddress = new Address()
                {
                    AddressType = 1,
                    Street = "Testowa",
                    City = "Warszawa",
                    Country = "Polska",
                    PostalCode = "00-000"
                },
                ShowOrderItems = new List<ShowOrderItems>()
                {
                     new ShowOrderItems()
                     {
                        Productname = "Test",
                        quantity = 1,
                        Price = 100,
                     },
                     new ShowOrderItems()
                     {
                        Productname = "Test 2",
                        quantity = 2,
                        Price = 50,
                     }
                }
            };
            //Act
            var current = orderRepository.getOrderToShow(10);

            //Assert
            Assert.AreEqual(expected.OrderId, current.OrderId);
            Assert.AreEqual(expected.OrderDate, current.OrderDate);
            Assert.AreEqual(expected.FirstName, current.FirstName);
            Assert.AreEqual(expected.LastName, current.LastName);

            Assert.AreEqual(expected.DeliveryAddress.AddressType, current.DeliveryAddress.AddressType);
            Assert.AreEqual(expected.DeliveryAddress.Street, current.DeliveryAddress.Street);
            Assert.AreEqual(expected.DeliveryAddress.PostalCode, current.DeliveryAddress.PostalCode);
            Assert.AreEqual(expected.DeliveryAddress.Country, current.DeliveryAddress.Country);

            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual(expected.ShowOrderItems[i].Productname, current.ShowOrderItems[i].Productname);
                Assert.AreEqual(expected.ShowOrderItems[i].quantity, current.ShowOrderItems[i].quantity);
            }
        }
    }
}
