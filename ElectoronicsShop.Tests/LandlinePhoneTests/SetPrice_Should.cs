using ElectronicsShop.Models.Products;
using ElectronicsShop.Models.Products.Phones;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ElectronicsShop.Tests.LandlinePhoneTests
{
    [TestClass]
    public class SetPrice_Should
    {
        [DataTestMethod]
        [DataRow(0)]
        [DataRow(-10)]
        public void ThrowArgumentOutOfRangeException__WhenNegativeOrZeroValueIsPassed(int price)
        {
            //Arrange
            var phone = new LandlinePhone("Vivacom", "Home", "White", 10, new PhoneSize(2, 5, 4), 2, 500);

            //Act & Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => phone.Price=price);
        }
    }
}
