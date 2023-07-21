using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorApp.Models;
using System.Collections.Generic;
using System;


namespace VendorApp.Solution
{
    [TestClass]

    public class VendorTests
    {
        [TestMethod]
        public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
        {
            Vendor newVendor = new Vendor("New Vendor");
            Assert.AreEqual(typeof(Vendor), newVendor.GetType());
        }
    }
}