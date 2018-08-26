using ElectronicsShop.Models.Products;
using ElectronicsShop.Models.Products.Phones;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ElectronicsShop.Tests.SmartphoneTests
{
    [TestClass]
    public class PriceParameter_Should
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
        public void SetPrice_WhenObjectIsCreated()
        {
            var smartphone = new Smartphone(brand, model, colour, batteryType, displaySize, phoneSize, processor, ram, price);

            Assert.AreEqual(smartphone.Price, 500);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ThrowException_WhenNegativePriceIsPassed()
        {
            price = -1;
            var smartphone = new Smartphone(brand, model, colour, batteryType, displaySize, phoneSize, processor, ram, price);

            Assert.AreEqual(smartphone.Price, -1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ThrowException_WhenZeroPriceIsPassed()
        {
            price = 0;
            var smartphone = new Smartphone(brand, model, colour, batteryType, displaySize, phoneSize, processor, ram, price);

            Assert.AreEqual(smartphone.Price, 0);
        }

    }
}
