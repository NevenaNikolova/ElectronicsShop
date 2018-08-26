using ElectronicsShop.Models.Products;
using ElectronicsShop.Models.Products.Phones;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ElectronicsShop.Tests.SmartphoneTests
{
    [TestClass]
    public class IDParameter_Should
    {
        string brand = "Lenovo";
        string model = "note3";
        string colour = "white";
        string batteryType = "NiCd";
        int displaySize = 5;
        PhoneSize phoneSize = new PhoneSize(2, 2, 5);
        string processor = "amd";
        int ram = 2;
        decimal price = 500;

        [TestMethod]
        public void SetId_WhenObjectIsCreated()
        {
            var smartphone = new Smartphone(brand, model, colour, batteryType, displaySize, phoneSize, processor, ram, price);

            Assert.AreEqual(smartphone.ID, 1);
        }

        [TestMethod]
        public void SetId_WhenMoreThanOneObjectsAreCreated()
        {
            var smartphone = new Smartphone(brand, model, colour, batteryType, displaySize, phoneSize, processor, ram, price);
            var smartphone2 = new Smartphone(brand, model, colour, batteryType, displaySize, phoneSize, processor, ram, price);

            Assert.AreEqual(smartphone2.ID, 2);
        }
    }
}
