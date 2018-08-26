using ElectronicsShop.Models.Products;
using ElectronicsShop.Models.Products.Phones;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ElectronicsShop.Tests.SmartphoneTests
{
    [TestClass]
    public class BrandParameter_Should
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
        public void SetBrand_WhenObjectIsCreated()
        {
            var smartphone = new Smartphone(brand, model, colour, batteryType, displaySize, phoneSize, processor, ram, price);

            Assert.AreEqual(smartphone.Brand, "Lenovo");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ThrowException_WhenEmptyStringIsPassed()
        {
            string brand = "        ";

            var smartphone = new Smartphone(brand, model, colour, batteryType, displaySize, phoneSize, processor, ram, price);

            Assert.AreEqual(smartphone.Brand, "        ");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ThrowException_WhenNullStringIsPassed()
        {
            string brand = null;

            var smartphone = new Smartphone(brand, model, colour, batteryType, displaySize, phoneSize, processor, ram, price);

            Assert.AreEqual(smartphone.Brand, "");
        }

    }
}
