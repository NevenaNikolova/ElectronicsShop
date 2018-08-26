using ElectronicsShop.Models.Products;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ElectoronicsShop.Tests.LaptopTests
{
    [TestClass]
    public class Brand_Should
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ThrowArgumentNullException_WhenNullValuePassed()
        {
            //arrange
            //string brand = "Valid brand";
            string model = "valid model";
            int displaySize = 13;
            int batteryCapacity = 1000;
            string processor = "Valid";
            int ram = 4;
            int hdd = 200;
            int videoCard = 2;
            int price = 100;
            //act
            var laptop = new Laptop(null, model, displaySize, batteryCapacity, processor, ram, hdd, videoCard, price);

        }

        [TestMethod]
        public void AssignCorrectly_WhenValidValuePassed()
        {
            //arrange
            string brand = "Valid brand";
            string model = "valid model";
            int displaySize = 13;
            int batteryCapacity = 1000;
            string processor = "Valid";
            int ram = 4;
            int hdd = 200;
            int videoCard = 2;
            int price = 100;
            //act
            var laptop = new Laptop(brand, model, displaySize, batteryCapacity, processor, ram, hdd, videoCard, price);
            var sut = laptop.Brand;

            //assert
            Assert.AreEqual(brand,sut);
        }
    }
}
