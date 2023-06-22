using System.Collections.Generic;

namespace PartsUnlimited.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Color { get; set; } // Added Color property
        public List<Product> Products { get; set; }
    }
}
