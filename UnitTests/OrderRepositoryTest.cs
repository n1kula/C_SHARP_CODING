using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using C_SHARP_CODING;

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
    }
}
