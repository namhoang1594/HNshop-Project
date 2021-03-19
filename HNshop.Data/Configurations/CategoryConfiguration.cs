using HNshop.Data.Entities;
using HNshop.Data.Enum;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HNshop.Data.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories");
            builder.HasKey(pk => pk.Id);
            builder.Property(p => p.Id).UseIdentityColumn();
            builder.Property(p => p.Name).IsRequired().HasMaxLength(200);
            builder.Property(p => p.SeoAlias).IsRequired().HasMaxLength(200);
            builder.Property(p => p.SeoDescription).HasMaxLength(500);
            builder.Property(p => p.SeoTitle).HasMaxLength(200);
            builder.Property(p => p.Status).HasDefaultValue(Status.Active);
        }
    }
}
