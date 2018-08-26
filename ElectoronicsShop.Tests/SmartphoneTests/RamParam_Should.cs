using ElectronicsShop.Models.Products;
using ElectronicsShop.Models.Products.Phones;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ElectronicsShop.Tests.SmartphoneTests
{
    [TestClass]
    public class RamParam_Should
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
        public void SetRam_WhenObjectIsCreated()
        {
            var smartphone = new Smartphone(brand, model, colour, batteryType, displaySize, phoneSize, processor, ram, price);

            Assert.AreEqual(smartphone.Ram, 2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ThrowArgumentException_WhenNegativeRamIsGiven()
        {
            ram = -1;
            var smartphone = new Smartphone(brand, model, colour, batteryType, displaySize, phoneSize, processor, ram, price);

            Assert.AreEqual(smartphone.Ram, -1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ThrowArgumentException_WhenNullRamIsGiven()
        {
            ram = 0;
            var smartphone = new Smartphone(brand, model, colour, batteryType, displaySize, phoneSize, processor, ram, price);

            Assert.AreEqual(smartphone.Ram, 0);
        }

    }
}
