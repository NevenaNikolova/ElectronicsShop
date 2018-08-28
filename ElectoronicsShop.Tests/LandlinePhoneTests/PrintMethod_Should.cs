using ElectronicsShop.Models.Products;
using ElectronicsShop.Models.Products.Phones;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ElectronicsShop.Tests.LandlinePhoneTests
{
    [TestClass]
    public class PrintMethod_Should
    {
        [TestMethod]
        public void ReturnStringtWithProperLandlinePhoneParameters_WhenItIsCalled()
        {
            //Arrange
            var phone = new LandlinePhone("Vivacom", "Home", "White", 10, new PhoneSize(2, 5, 4), 2, 500);           
            //Act
            var result = phone.Print();

            //Assert
            StringAssert.Contains(result, "Brand: Vivacom");
            StringAssert.Contains(result, "Model: Home");
            StringAssert.Contains(result, "Colour: White");
            StringAssert.Contains(result, "Display size: 10");
            StringAssert.Contains(result, "AnalogueLines: 2");
            StringAssert.Contains(result, "Price: 500");
        }
    }
}
