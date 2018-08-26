using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using ElectronicsShop.Models.Products.Phones;
using ElectronicsShop.Models.Products;

namespace ElectronicsShop.Tests.LandlinePhoneTests
{
    [TestClass]
    public class Constructor_Should
    {
        [TestMethod]
        public void SetProperBrand_WhenTheObjectIsConstructed()
        {
            //Arrange & Act
            var phone = new LandlinePhone("Vivacom", "Home", "White", 10, new PhoneSize(2, 5, 4), 2, 500);
            //Assert
            Assert.AreEqual("Vivacom", phone.Brand);
        }
        [TestMethod]
        public void SetProperModel_WhenTheObjectIsConstructed()
        {
            //Arrange & Act
            var phone = new LandlinePhone("Vivacom", "Home", "White", 10, new PhoneSize(2, 5, 4), 2, 500);
            //Assert
            Assert.AreEqual("Home", phone.Model);
        }
        [TestMethod]
        public void SetProperColour_WhenTheObjectIsConstructed()
        {
            //Arrange & Act
            var phone = new LandlinePhone("Vivacom", "Home", "White", 10, new PhoneSize(2, 5, 4), 2, 500);
            //Assert
            Assert.AreEqual("White", phone.Colour);
        }
        [TestMethod]
        public void SetProperDisplaySize_WhenTheObjectIsConstructed()
        {
            //Arrange & Act
            var phone = new LandlinePhone("Vivacom", "Home", "White", 10, new PhoneSize(2, 5, 4), 2, 500);
            //Assert
            Assert.AreEqual(10, phone.DisplaySize);
        }
        [TestMethod]
        public void SetProperPhoneSize_WhenTheObjectIsConstructed()
        {
            //Arrange & Act
            var size = new PhoneSize(2, 5, 4);
            var phone = new LandlinePhone("Vivacom", "Home", "White", 10,size, 2, 500);
            //Assert
            Assert.AreEqual(size,phone.Size);
        }
        [TestMethod]
        public void SetProperAnalogueLines_WhenTheObjectIsConstructed()
        {
            //Arrange & Act
            var phone = new LandlinePhone("Vivacom", "Home", "White", 10, new PhoneSize(2, 5, 4), 2, 500);
            //Assert
            Assert.AreEqual(2, phone.AnalogueLines);
        }
        [TestMethod]
        public void SetProperPrice_WhenTheObjectIsConstructed()
        {
            //Arrange & Act
            var phone = new LandlinePhone("Vivacom", "Home", "White", 10, new PhoneSize(2, 5, 4), 2, 500);
            //Assert
            Assert.AreEqual(500, phone.Price);
        }

    }
}
