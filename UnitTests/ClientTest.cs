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
    }
}
