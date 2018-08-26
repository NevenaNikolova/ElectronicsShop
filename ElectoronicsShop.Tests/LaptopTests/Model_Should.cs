using ElectronicsShop.Models.Products;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ElectronicsShop.Tests.LaptopTests
{
    [TestClass]
    public class Model_Should
    {
        [TestMethod]
        public void AssignCorrectly_WhenValidValuePassed()
        {
            //arrange
            string brand = "Valid brand";
            string model = "valid model";
            int displaySize = 13;
            int batteryCapacity = 2000;
            string processor = "Valid";
            int ram = 4;
            int hdd = 200;
            int videoCard = 2;
            int price = 100;
            //act
            var laptop = new Laptop(brand, model, displaySize, batteryCapacity, processor, ram, hdd, videoCard, price);

            var sut = laptop.Model;

            //assert
            Assert.AreEqual(model, sut);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ThrowArgumentNullException_WhenNullValuePassed()
        {
            //arrange
            string brand = "Valid brand";
            //string model = "valid model";
            int displaySize = 13;
            int batteryCapacity = 2000;
            string processor = "Valid";
            int ram = 4;
            int hdd = 200;
            int videoCard = 2;
            int price = 100;
            //act
            var laptop = new Laptop(brand, null, displaySize, batteryCapacity, processor, ram, hdd, videoCard, price);
            
        }
    }
}
