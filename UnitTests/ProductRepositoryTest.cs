using System;
using C_SHARP_CODING;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void getProduct()
        {
            //Arrange
            var productRepository = new ProductRepository();
            var expected = new Product(2)
            {
                ProductName = "Milk",
                Description = "Laciate 3,2%",
                CurrentPrice = 5
             };
            //Act
            var current = productRepository.getData(2);
            
            //Assert
            Assert.AreEqual(expected.ProductName, current.ProductName);
            Assert.AreEqual(expected.Description, current.Description);
            Assert.AreEqual(expected.CurrentPrice, current.CurrentPrice);
        }
    }
}
