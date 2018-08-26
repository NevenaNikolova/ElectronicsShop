using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ElectronicsShop.Tests.LaptopTests
{
    [TestClass]
   public class Print_Should
    {
        [TestMethod]
        public void ReturnStringWithObjectPropertieValues()
        {
            //arrange
            string brand = "valid brand";
            string model = "valid model";
            int displaySize = 13;
            int batteryCapacity = 2500;
            string processor = "Valid";
            int ram = 4;
            int hdd = 200;
            int videoCard = 2;
            int price = 100;
            //act
            var laptop = new Models.Products.Laptop(brand, model, displaySize, batteryCapacity, processor, ram, hdd, videoCard, price);
            //assert
            var result = laptop.Print();
            //assert
            Assert.IsTrue(result.Contains(brand));
        }
    }
}
