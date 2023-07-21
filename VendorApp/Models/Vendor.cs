using System.Collections.Generic;

namespace VendorApp.Models
{
    public class Vendor
    {
        private static List<Vendor> _instances = new List<Vendor> {};
        public string Name { get; set; }
        public Vendor(string vendorName)
        {
            Name = vendorName;
            _instances.Add(this);
        }
        public static List<Vendor> GetAll()
        {
            return _instances;
        }
    }
}