using System.Collections.Generic;

namespace VendorApp.Models
{
    public class Vendor
    {
        public string Name { get; set; }
        public Vendor(string vendorName)
        {
            name = vendorName;
        }

    }
}