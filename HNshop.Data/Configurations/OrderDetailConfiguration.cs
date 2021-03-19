using HNshop.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HNshop.Data.Configurations
{
    public class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.ToTable("OrderDetails");
            builder.HasKey(pk => new { pk.OrderId, pk.ProductId });
            builder.HasOne(fk => fk.Order).WithMany(fk => fk.OrderDetails).HasForeignKey(fk => fk.OrderId);
            builder.HasOne(fk => fk.Product).WithMany(fk => fk.OrderDetails).HasForeignKey(fk => fk.ProductId);
        }
    }
}
