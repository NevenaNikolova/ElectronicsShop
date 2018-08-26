using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ElectronicsShop.Tests.Database.Test
{
    [TestClass]
    public class Constructor_Should
    {
        [TestMethod]
        public void Assign_ProductsList_WhenInvoked()
        {
            var database = new Models.Database();
            Assert.IsNotNull(database.Products);
        }
    }
}
