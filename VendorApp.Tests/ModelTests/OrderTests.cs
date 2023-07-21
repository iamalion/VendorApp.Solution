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

        [TestMethod]
        public void GetTitle_ReturnsSameTitle_String()
        {
            string title = "title";
            Order newOrder = new Order(title, "description", 50, "7/21/2023", true);
            string result = newOrder.Title;
            Assert.AreEqual(title, result);
        }

        [TestMethod]
        public void GetDescription_ReturnsSameDescription_String()
        {
            string description = "description";
            Order newOrder = new Order("title", description, 50, "7/21/2023", true);
            string result = newOrder.Description;
            Assert.AreEqual(description, result);
        }

        [TestMethod]
        public void GetPrice_ReturnsSamePrice_Price()
        {
            int price = 50;
            Order newOrder = new Order("title", "description", 50, "7/21/2023", true);
            int result = newOrder.Price;
            Assert.AreEqual(price, result);
        }

        [TestMethod]
        public void GetDate_ReturnsSameDate_Date()
        {
            string date = "7/21/2023";
            Order newOrder = new Order("title", "description", 50, date, true);
            string result = newOrder.Date;
            Assert.AreEqual(date, result);
        }

    }

}