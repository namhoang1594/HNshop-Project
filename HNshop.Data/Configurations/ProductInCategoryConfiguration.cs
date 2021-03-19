using HNshop.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HNshop.Data.Configurations
{
    public class ProductInCategoryConfiguration : IEntityTypeConfiguration<ProductInCategory>
    {
        public void Configure(EntityTypeBuilder<ProductInCategory> builder)
        {
            builder.ToTable("ProductInCategories");
            builder.HasKey(pk => new { pk.CategoryId, pk.ProductId });
            builder.HasOne(fk => fk.Product).WithMany(fk => fk.ProductInCategories).HasForeignKey(fk => fk.ProductId);
            builder.HasOne(fk => fk.Category).WithMany(fk => fk.ProductInCategories).HasForeignKey(fk => fk.CategoryId);
        }
    }
}
