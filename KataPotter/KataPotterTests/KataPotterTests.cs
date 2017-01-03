using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingDojo;

namespace CodingDojo
{
    [TestClass]
    public class KataPotterTests
    {
        [TestMethod]
        public void Returns0IfNoBooks()
        {
            //Arrange
            //Act
            var result = KataPotter.GetPrice(new int[] { });
            //Assert
            Assert.AreEqual(0, result);
        }
    }
}
