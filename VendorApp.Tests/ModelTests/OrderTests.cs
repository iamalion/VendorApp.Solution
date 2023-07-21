using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorApp.Models;
using System;

namespace VendorApp.Tests
{
    [TestClass]
    public class OrderTests : IDisposable
    {
        public void Dispose()
        {
            Order.ClearAll();
        }
        [TestMethod]
        public void OrderConstructor_CreatesInstanceOfOrder_Order()
        {
            Order newOrder = new Order("title", "description", 50, "7/21/2023");
           
            Assert.AreEqual(typeof(Order), newOrder.GetType());
        }

        [TestMethod]
        public void GetTitle_ReturnsSameTitle_String()
        {
            string title = "title";
            Order newOrder = new Order(title, "description", 50, "7/21/2023");
            
            string result = newOrder.Title;
            
            Assert.AreEqual(title, result);
        }

        [TestMethod]
        public void GetDescription_ReturnsSameDescription_String()
        {
            string description = "description";
            Order newOrder = new Order("title", description, 50, "7/21/2023");
            
            string result = newOrder.Description;
            
            Assert.AreEqual(description, result);
        }

        [TestMethod]
        public void GetPrice_ReturnsSamePrice_Price()
        {
            int price = 50;
            Order newOrder = new Order("title", "description", 50, "7/21/2023");
            
            int result = newOrder.Price;
            
            Assert.AreEqual(price, result);
        }

        [TestMethod]
        public void GetDate_ReturnsSameDate_Date()
        {
            string date = "7/21/2023";
            Order newOrder = new Order("title", "description", 50, date);

            string result = newOrder.Date;
            
            Assert.AreEqual(date, result);
        }

        [TestMethod]
        public void GetAll_ReturnsEmptyList_ItemList()
        {
            List<Order> newList = new List<Order> { };

            List<Order> result = Order.GetAll();

            CollectionAssert.AreEqual(newList, result);
        }
        [TestMethod]
        public void GetAll_ReturnsOrders_OrderList()
        {
            string title1 = "Title One";
            string description1 = "Description One";
            int price1 = 10;
            string date1 = "7/21/2023";
            string title2 = "Title Two";
            string description2 = "Description Two";
            int price2 = 100;
            string date2 = "7/21/2023";
            Order newOrder1 = new Order(title1, description1, price1, date1);
            Order newOrder2 = new Order(title2, description2, price2, date2);
            List<Order> newList = new List<Order> { newOrder1, newOrder2 };

            List<Order> result = Order.GetAll();

            CollectionAssert.AreEqual(newList, result);

        }
        [TestMethod]
        public void GetId_OrdersInstantiateWithAnIdAndGetterReturns_Int()
        {
            string title1 = "Title One";
            string description1 = "Description One";
            int price1 = 10;
            string date1 = "7/21/2023";
            Order newOrder = new Order(title1, description1, price1, date1);

            int result = newOrder.Id;

            Assert.AreEqual(1, result);
        }
        public void Find_ReturnsCorrectOrder_Order()
        {
            string title1 = "Title One";
            string description1 = "Description One";
            int price1 = 10;
            string date1 = "7/21/2023";
            string title2 = "Title Two";
            string description2 = "Description Two";
            int price2 = 100;
            string date2 = "7/21/2023";
            Order newOrder1 = new Order(title1, description1, price1, date1);
            Order newOrder2 = new Order(title2, description2, price2, date2);

            Order result = Order.Find(2);

            Assert.AreEqual(newOrder2, result);
        }
        [TestMethod]
        public void AddOrder_AssociatesOrderWithVendor_OrderList()
        {
            string title1 = "Title One";
            string description1 = "Description One";
            int price1 = 10;
            string date1 = "7/21/2023";
            Order newOrder = new Order(title1, description1, price1, date1);
            List<Order> newList = new List<Order> { newOrder };
            string name = "Work";
            Vendor newVendor = new Vendor(name);
            newVendor.AddOrder(newOrder);

            List<Order> result = newVendor.Orders;

            CollectionAssert.AreEqual(newList, result);            
        }
    }
}