using HNshop.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HNshop.Data.Configurations
{
    public class PromotionConfiguration : IEntityTypeConfiguration<Promotion>
    {
        public void Configure(EntityTypeBuilder<Promotion> builder)
        {
            builder.ToTable("Promotions");
            builder.HasKey(pk => pk.Id);
            builder.Property(p => p.Id).UseIdentityColumn();
            builder.Property(p => p.Name).IsRequired();
        }
    }
}
