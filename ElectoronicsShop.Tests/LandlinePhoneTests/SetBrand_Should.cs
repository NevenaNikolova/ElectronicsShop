using ElectronicsShop.Models.Products;
using ElectronicsShop.Models.Products.Phones;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace ElectronicsShop.Tests.LandlinePhoneTests
{
    [TestClass]
    public class SetBrand_Should
    {
        [TestMethod]
        public void SetProperValue_WhenTheSetMethodIsCalled(string brand)
        {
            //Arrange
            var phone = new LandlinePhone(brand, "Home", "White", 10, new PhoneSize(2, 5, 4), 2, 500);
            //Act
            phone.Brand = "Vivacom";
            //Assert
            Assert.AreEqual(brand, phone.Brand);
        }

        [DataTestMethod]
        [DataRow(null)]
        [DataRow(" ")]
        public void ThrowsArgumentNullException_WhenTheValueIsNullOrEmpty(string brand)
        {
            //Arrange
            var phone = new LandlinePhone("Vivacom", "Home", "White", 10, new PhoneSize(2, 5, 4), 2, 500);

            //Act & Assert
            Assert.ThrowsException<ArgumentNullException>(() => phone.Brand = brand);
        }
    }
}
