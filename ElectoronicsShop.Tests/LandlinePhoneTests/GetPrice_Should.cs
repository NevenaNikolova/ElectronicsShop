using ElectronicsShop.Models.Products;
using ElectronicsShop.Models.Products.Phones;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ElectronicsShop.Tests.LandlinePhoneTests
{
    [TestClass]
    public class GetPrice_Should
    {
        [TestMethod]
        public void ReturnTheProperValue_WhenTheGetMethodIsCalled()
        {
            //Arrange
            var phone = new LandlinePhone("Vivacom", "Home", "White", 10, new PhoneSize(2, 5, 4), 2, 500);
            //Act
            var result = phone.Price;
            //Assert
            Assert.AreEqual(500, result);
        }
    }
}
