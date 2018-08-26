using ElectronicsShop.Models.ComputerContracts;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;

namespace ElectronicsShop.Tests.Database.Test
{
    [TestClass]
    public class RemoveProduct_Should
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ThrowArgumentNullException_WhenNullParameterIsPassed()
        {
            //arrange
            var database = new Models.Database();
            var productStub = new Mock<IProduct>();
            //act
            database.RemoveProduct(null);
            //assert
           
        }
        [TestMethod]
        public void RemoveExistingProductFromCollectionCorrectly_WhenValidObjectIsPassed()
        {
            //arrange
            var database = new Models.Database();
            var productStub = new Mock<IProduct>();
            //act
            database.AddProduct(productStub.Object);
            database.RemoveProduct(productStub.Object);
            //assert
            Assert.IsTrue(database.Products.Count == 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ThrowArgumentException_WhenTryingToRemoveProductWhoIsNotInCollection()
        {
            //arrange
            var database = new Models.Database();

            var productStub = new Mock<IProduct>();
            //act
            database.RemoveProduct(productStub.Object);
            
        }
    }
}
