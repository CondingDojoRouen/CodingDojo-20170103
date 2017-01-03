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

        [TestMethod]
        public void Returns8If1Book()
        {
            //Arrange
            //Act
            var result = KataPotter.GetPrice(new int[] { 1 });
            //Assert
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void ThrowsExceptionIfIncorrectBook()
        {
            //Arrange
            int[] potterArray = new int[] { 10 };
            //Act
            //Assert
            Assert.ThrowsException<ArgumentException>(() => 
                KataPotter.GetPrice(potterArray)
            );
        }
    }
}
