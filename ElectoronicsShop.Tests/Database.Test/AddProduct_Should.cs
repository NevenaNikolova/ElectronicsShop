using ElectronicsShop.Models.Contracts;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using ElectronicsShop.Models;
using ElectronicsShop.Models.ComputerContracts;

namespace ElectronicsShop.Tests.Database.Test
{
    [TestClass]
   public class AddProduct_Should
    {
        [TestMethod]
        public void AddProductCorrectlyToProductList_WhenValidParametersArePassed()
        {
            //arrange
            var database = new Models.Database();
            var productMock = new Mock<IProduct>();
            //act
            database.AddProduct(productMock.Object);
            //assert
            Assert.IsTrue(database.Products.Contains(productMock.Object));
            
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ThrowArgumenNullException_WhenNullArgumentIsPassed()
        {
            //arrange
            var database = new Models.Database();
            //act
            database.AddProduct(null);
        }
    }
}
