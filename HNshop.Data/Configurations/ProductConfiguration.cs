using HNshop.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HNshop.Data.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");
            builder.HasKey(pk => pk.Id);
            builder.Property(p => p.Id).UseIdentityColumn();
            builder.Property(p => p.Name).IsRequired().HasMaxLength(200);
            builder.Property(p => p.Description).HasMaxLength(500);
            builder.Property(p => p.Details).HasMaxLength(500);
            builder.Property(p => p.Price).IsRequired();
            builder.Property(p => p.OriginalPrice).IsRequired();
            builder.Property(p => p.Stock).IsRequired().HasDefaultValue(0);
            builder.Property(p => p.SeoAlias).IsRequired().HasMaxLength(200);
            builder.Property(p => p.SeoDescription).HasMaxLength(500);
            builder.Property(p => p.SeoTitle).HasMaxLength(200);
            builder.Property(p => p.ViewCount).IsRequired().HasDefaultValue(0);
        }
    }
}
