using ElectronicsShop.Models.ComputerContracts;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;

namespace ElectronicsShop.Tests.Database.Test
{
    [TestClass]
    public class Contains_Should
    {
        [TestMethod]
        public void ReturnTrue_WhenExistingProductIdIsPassed()
        {
            //arrange
            var database = new Models.Database();
            var productMock = new Mock<IProduct>();
            productMock.SetupGet(x => x.ID).Returns(1);
            database.AddProduct(productMock.Object);

            //act & assert
            Assert.IsTrue(database.Contains(productMock.Object.ID));
        }

        [TestMethod]
        public void ReturnFalse_WhenUnexistingProductIdIsPassed()
        {
            //arrange
            var database = new Models.Database();
            int unexistingId = 1;
            //act & assert
            Assert.IsFalse(database.Contains(unexistingId));
        }
    }
}
