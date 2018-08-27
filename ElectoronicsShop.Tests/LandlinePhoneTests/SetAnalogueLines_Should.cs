using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using ElectronicsShop.Models.Products;
using ElectronicsShop.Models.Products.Phones;

namespace ElectronicsShop.Tests.LandlinePhoneTests
{
    [TestClass]
    public class SetAnalogueLines_Should
    {
        [TestMethod]
        public void ThrowArgumentOutOfRangeException__WhenNegativeValueIsPassed()
        {
            //Arrange
            var phone = new LandlinePhone("Vivacom", "Home", "White", 10, new PhoneSize(2, 5, 4), 2, 500);

            //Act & Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => phone.AnalogueLines=-2);
        }
    }
}
