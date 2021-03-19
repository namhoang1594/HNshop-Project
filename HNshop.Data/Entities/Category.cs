using HNshop.Data.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace HNshop.Data.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SortOrder { get; set; }
        public bool IsShowOnHome { get; set; }
        public int? ParentID { get; set; }
        public string SeoDescription { get; set; }
        public string SeoTitle { get; set; }
        public string SeoAlias { get; set; }
        public Status Status { get; set; }
        public List<ProductInCategory> ProductInCategories { get; set; }

    }
}
