using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorApp.Models;
using System.Collections.Generic;
using System;

namespace VendorApp.Solution
{
    [TestClass]

    public class VendorTests : IDisposable
    {
        public void Dispose()
        {
            Vendor.ClearAll();
        }

        [TestMethod]
        public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
        {
            Vendor newVendor = new Vendor("New Vendor");
            Assert.AreEqual(typeof(Vendor), newVendor.GetType());
        }

        [TestMethod]
        public void GetVendorName_ReturnsVendorName_String()
        {
            string vendorName = "Vendor Name";
            Vendor newVendor = new Vendor(vendorName);
        }
        [TestMethod]
        public void GetId_ReturnsVendorId_Int()
        {
            string name = "Vendor Name";
            Vendor newVendor = new Vendor(name);

            int result = newVendor.Id;

            Assert.AreEqual(1, result);
        }

    }
}