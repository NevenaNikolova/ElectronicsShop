using ElectronicsShop.Models.Products;
using ElectronicsShop.Models.Products.Phones;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ElectronicsShop.Tests.SmartphoneTests
{
    [TestClass]
    public class ProcessorParam_Should
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
        public void SetProcessor_WhenObjectIsCreated()
        {
            var smartphone = new Smartphone(brand, model, colour, batteryType, displaySize, phoneSize, processor, ram, price);

            Assert.AreEqual(smartphone.Processor, "amd");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ThrowArgumentNullException_WhenSpaceParameterIsGiven()
        {
            processor = " ";
            var smartphone = new Smartphone(brand, model, colour, batteryType, displaySize, phoneSize, processor, ram, price);

            Assert.AreEqual(smartphone.Processor, " ");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ThrowArgumentNullException_WhenEmptyStringParameterIsGiven()
        {
            processor = null;
            var smartphone = new Smartphone(brand, model, colour, batteryType, displaySize, phoneSize, processor, ram, price);

            Assert.AreEqual(smartphone.Processor, "");
        }

    }
}
