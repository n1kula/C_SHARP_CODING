using System;
using Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CommonTest
{
    [TestClass]
    public class StringSupportTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange
            var source = "TestNazwyCammel";
            var expected = "Test Nazwy Cammel";
            var stringSupport = new StringSupport();

            //act
            var current = stringSupport.AddSpace(source);

            //assert
            Assert.AreEqual(expected, current);
        }
    }
}
