using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using VendorApp.Models;


namespace VendorApp.Controllers 
{
    public class VendorsController : Controller
    {
        [HttpGet("/vendors")]
        public ActionResult Index()
        {
            List<Vendor> allVendors = Vendor.GetAll();
            return View(allVendors);
        }

        [HttpGet("/vendors/new")]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost("/vendors")]
        public ActionResult Create(string vendorName)
        {
            Vendor newVendor = new Vendor(vendorName);
            return RedirectToAction("Index", "Home");
        }

        [HttpGet("/vendors/{id}")]
        public ActionResult Show(int id)
        {
            Dictionary<string, object> model = new Dictionary<string, object>();
            Vendor selectedVendor = Vendor.Find(id);
            List<Order> vendorOrders = selectedVendor.Orders;
            model.Add("vendor", selectedVendor);
            model.Add("order", vendorOrders);
            return View(model);
        }

         [HttpPost("/vendors/{vendorId}/orders")]
        public ActionResult Create(int vendorId, string orderTitle, string orderDescription, int orderPrice, string orderDate)
        {
            Vendor foundVendor = Vendor.Find(vendorId);
            if (foundVendor == null)
            {
                return RedirectToAction("Error"); 
            }

            Order newOrder = new Order(orderTitle, orderDescription, orderPrice, orderDate);
            foundVendor.AddOrder(newOrder);

            return RedirectToAction("Show", "Orders", new { vendorId = vendorId, orderId = newOrder.Id });
        }
    }
}