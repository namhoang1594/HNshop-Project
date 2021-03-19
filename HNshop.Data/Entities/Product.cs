using System;
using System.Collections.Generic;
using System.Text;

namespace HNshop.Data.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal OriginalPrice { get; set; }
        public string Details { get; set; }
        public int Stock { get; set; }
        public string SeoDescription { get; set; }
        public string SeoTitle { get; set; }
        public int ViewCount { get; set; }
        public DateTime DateCreated { get; set; }
        public string SeoAlias { get; set; }
        public bool? IsFeatured { get; set; }

        public List<ProductInCategory> ProductInCategories { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        public List<Cart> Carts { get; set; }
        //public List<ProductImage> ProductImages { get; set; }
    }
}
