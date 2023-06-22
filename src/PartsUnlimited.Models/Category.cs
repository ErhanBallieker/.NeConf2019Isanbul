   using System.Collections.Generic;

   namespace PartsUnlimited.Models
   {
       public class Category
       {
           public int Id { get; set; }
           public string Name { get; set; }
           public string Description { get; set; }
           public string ImageUrl { get; set; }
           public string Color { get; set; } // New property
           public List<Product> Products { get; set; }
       }
   }
   