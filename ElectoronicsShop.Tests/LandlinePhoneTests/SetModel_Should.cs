using ElectronicsShop.Models.Products;
using ElectronicsShop.Models.Products.Phones;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ElectronicsShop.Tests.LandlinePhoneTests
{
    [TestClass]
    public class SetModel_Should
    {
        [DataTestMethod]
        [DataRow(null)]
        [DataRow(" ")]
        public void ThrowsArgumentNullException_WhenTheValueIsNullOrEmpty(string model)
        {
            //Arrange
            var phone = new LandlinePhone("Vivacom", "Home", "White", 10, new PhoneSize(2, 5, 4), 2, 500);

            //Act & Assert
            Assert.ThrowsException<ArgumentNullException>(() => phone.Model = model);
        }
    }
}
