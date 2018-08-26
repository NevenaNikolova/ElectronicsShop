using ElectronicsShop.Models.Products;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ElectoronicsShop.Tests.LaptopTests
{
    [TestClass]
    public class Constructor_Should
    {
        [TestMethod]
        public void AssignBrandCorrectly_WhenValidValuePassed()
        {
            //arrange
            string brand = "valid brand";
            string model = "valid model";
            int displaySize = 13;
            int batteryCapacity = 1000;
            string processor = "Valid";
            int ram = 4;
            int hdd = 200;
            int videoCard = 2;
            int price = 100;
            //act
            var laptop = new Laptop(brand,model,displaySize,batteryCapacity,processor,ram,hdd,videoCard,price);
            //assert
            Assert.AreEqual(brand, laptop.Brand);

        }

        [TestMethod]
        public void AssignModelCorrectly_WhenValidValuePassed()
        {
            //arrange
            string brand = "valid brand";
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
            //assert
            Assert.AreEqual(model, laptop.Model);

        }

        [TestMethod]
        public void AssignDisplaySizeCorrectly_WhenValidValuePassed()
        {
            //arrange
            string brand = "valid brand";
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
            //assert
            Assert.AreEqual(displaySize, laptop.DisplaySize);

        }

        [TestMethod]
        public void AssignBateryCapacityCorrectly_WhenValidValuePassed()
        {
            //arrange
            string brand = "valid brand";
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
            //assert
            Assert.AreEqual(batteryCapacity, laptop.BatteryCapacity);

        }

        [TestMethod]
        public void AssignProcessorCorrectly_WhenValidValuePassed()
        {
            //arrange
            string brand = "valid brand";
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
            //assert
            Assert.AreEqual(processor, laptop.Processor);

        }

        [TestMethod]
        public void AssignRamCorrectly_WhenValidValuePassed()
        {
            //arrange
            string brand = "valid brand";
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
            //assert
            Assert.AreEqual(ram, laptop.Ram);

        }

        [TestMethod]
        public void AssignHddCorrectly_WhenValidValuePassed()
        {
            //arrange
            string brand = "valid brand";
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
            //assert
            Assert.AreEqual(hdd, laptop.Hdd);

        }

        [TestMethod]
        public void AssignVideoCardCorrectly_WhenValidValuePassed()
        {
            //arrange
            string brand = "valid brand";
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
            //assert
            Assert.AreEqual(videoCard, laptop.VideoCard);

        }

        [TestMethod]
        public void AssignPriceCorrectly_WhenValidValuePassed()
        {
            //arrange
            string brand = "valid brand";
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
            //assert
            Assert.AreEqual(price, laptop.Price);

        }
    }
}
