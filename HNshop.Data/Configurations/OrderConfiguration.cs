using HNshop.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HNshop.Data.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Orders");
            builder.HasKey(pk => pk.Id);
            builder.Property(p => p.Id).UseIdentityColumn();
            builder.Property(p => p.OrderDate).HasDefaultValue(DateTime.Now);
            builder.Property(p => p.ShipName).IsRequired().HasMaxLength(200);
            builder.Property(p => p.ShipAddress).IsRequired().HasMaxLength(200);
            builder.Property(p => p.ShipEmail).IsRequired().IsUnicode(false).HasMaxLength(50);
            builder.Property(p => p.ShipPhoneNumber).IsRequired().HasMaxLength(200);
        }
    }
}
