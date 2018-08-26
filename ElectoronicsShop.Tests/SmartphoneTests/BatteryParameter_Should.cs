using ElectronicsShop.Models.Products;
using ElectronicsShop.Models.Products.Phones;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ElectronicsShop.Tests.SmartphoneTests
{
    [TestClass]
    public class ColourParameter_Should
    {
        string brand = "Lenovo";
        string model = "note3";
        string colour = "White";
        string batteryType = "NiCd";
        int displaySize = 5;
        PhoneSize phoneSize = new PhoneSize(2, 2, 5);
        string processor = "amd";
        int ram = 2;
        decimal price = 500;

        [TestMethod]
        public void SetColourParameter_WhenObjectIsCreated()
        {
            var smartphone = new Smartphone(brand, model, colour, batteryType, displaySize, phoneSize, processor, ram, price);

            Assert.AreEqual(smartphone.Colour, "White");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ThrowException_WhenUnexistingColourIsPassed()
        {
            colour = "there is no such colour";
            var smartphone = new Smartphone(brand, model, colour, batteryType, displaySize, phoneSize, processor, ram, price);

            Assert.AreEqual(smartphone.Colour, "there is no such colour");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ThrowException_WhenWhiteSpaceColourIsPassed()
        {
            colour = "     ";
            var smartphone = new Smartphone(brand, model, colour, batteryType, displaySize, phoneSize, processor, ram, price);

            Assert.AreEqual(smartphone.Colour, "     ");
        }
    }
}
