using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorApp.Models;
using System;

namespace VendorApp.Tests
{
    [TestClass]
    public class OrderTests
    {
        [TestMethod]
        public void OrderConstructor_CreatesInstanceOfOrder_Order()
        {
            Order newOrder = new Order("title", "description", 50, "7/21/2023", true);
            Assert.AreEqual(typeof(Order), newOrder.GetType());
        }
    }
}