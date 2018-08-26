using ElectronicsShop.Models.ComputerContracts;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;

namespace ElectronicsShop.Tests.Database.Test
{
    [TestClass]
    public class GetProduct_Should
    {
        [TestMethod]
        public void ReturnProductWhenValidParameterIsPassed()
        {
            //arrange
            var database = new Models.Database();
            var productMock = new Mock<IProduct>();
            int id = 0;
            productMock.SetupGet(x => x.ID).Returns(id);
            database.AddProduct(productMock.Object);
            //act
            var result = database.GetProduct(id);
            //assert
            Assert.AreEqual(id, result.ID);
        }
    }
}
