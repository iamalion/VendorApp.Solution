using System.Collections.Generic;

namespace VendorApp.Models
{
    public class Order
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public string Date { get; set; }

        public int Id { get; }
        private static List<Order> _instances = new List<Order> { };

        public Order(string title, string description, int price, string date)
        {
            Title = title;
            Description = description;
            Price = price;
            Date = date;
            _instances.Add(this); // Add the current Order instance to the static list
            Id = _instances.Count; // Assign a unique Id to the Order
        }

        public static List<Order> GetAll()
        {
            return _instances;
        }
        public static void ClearAll()
        {
            _instances.Clear();
        }
    }
}