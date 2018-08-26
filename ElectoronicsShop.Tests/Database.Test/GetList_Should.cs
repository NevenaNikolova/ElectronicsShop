using ElectronicsShop.Models.Contracts.ComputerContracts;
using ElectronicsShop.Models.Contracts.PhoneContracts;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;

namespace ElectronicsShop.Tests.Database.Test
{
    [TestClass]
    public class GetList_Should
    {
        [TestMethod]
        public void ReturnListOfLaptops_WhenInvovedWithCorrespondingParameter()
        {
            //arrange
            var database = new Models.Database();
            var laptopMock = new Mock<ILaptop>();
            var expected = "mock";
            laptopMock.Setup(x => x.Print()).Returns(expected);
            laptopMock.SetupGet(x => x.Name).Returns("laptop");
            database.AddProduct(laptopMock.Object);
            //act
            string type = "laptop";
            var result = database.GetList(type);
            //assert
            Assert.IsTrue(result.Contains(expected));
        }

        [TestMethod]
        public void ReturnListOfSmartphones_WhenInvovedWithCorrespondingParameter()
        {
            //arrange
            var database = new Models.Database();
            var smartphoneMock = new Mock<ISmartphone>();
            var expected = "mock";
            string typeString = "smartphone";
            smartphoneMock.Setup(x => x.Print()).Returns(expected);
            smartphoneMock.SetupGet(x => x.Name).Returns(typeString);
            database.AddProduct(smartphoneMock.Object);
            //act
            var result = database.GetList(typeString);
            //assert
            Assert.IsTrue(result.Contains(expected));
        }

        [TestMethod]
        public void ReturnListOfLandlinephones_WhenInvovedWithCorrespondingParameter()
        {
            //arrange
            var database = new Models.Database();
            var laptopMock = new Mock<ILandlinePhone>();
            var expected = "mock";
            string typeString = "landlinephone";
            laptopMock.Setup(x => x.Print()).Returns(expected);
            laptopMock.SetupGet(x => x.Name).Returns(typeString);
            database.AddProduct(laptopMock.Object);
            //act
            var result = database.GetList(typeString);
            //assert
            Assert.IsTrue(result.Contains(expected));
        }

        [TestMethod]
        public void ReturnListOfDesktopCompuers_WhenInvovedWithCorrespondingParameter()
        {
            //arrange
            var database = new Models.Database();
            var desktopPcMock = new Mock<IDesktopComputer>();
            var expected = "mock";
            string typeString = "desktoppc";
            desktopPcMock.Setup(x => x.Print()).Returns(expected);
            desktopPcMock.SetupGet(x => x.Name).Returns(typeString);
            database.AddProduct(desktopPcMock.Object);
            //act
            var result = database.GetList(typeString);
            //assert
            Assert.IsTrue(result.Contains(expected));
        }

        [TestMethod]
        public void ThrowArgumentException_WhenInvalidParameterIsPassed()
        {
            //arrange
            var database = new Models.Database();
            string typeString = "Tomatoes";

            //assert
            Assert.ThrowsException<ArgumentException>(() => database.GetList(typeString));

        }
        [TestMethod]
        public void ThrowArgumentException_WhenNullParameterIsPassed()
        {
            //arrange
            var database = new Models.Database();
            //assert
            Assert.ThrowsException<ArgumentException>(() => database.GetList(null));

        }
    }
}
