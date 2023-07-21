using System.Collections.Generic;

namespace VendorApp.Models
{
    public class Order
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public string Date { get; set; }
        public bool IsRush { get; set; }
        public Order(string title, string description, int price, string date, bool isRush)
        {
            Title = title;
            Description = description;
            Price = price;
            Date = date;
            IsRush = isRush;
        }

    }
}