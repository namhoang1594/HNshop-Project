using HNshop.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HNshop.Data.Configurations
{
    public class AppConfigConfiguration : IEntityTypeConfiguration<AppConfig>
    {
        public void Configure(EntityTypeBuilder<AppConfig> builder)
        {
            builder.ToTable("AppConfigurations");
            builder.HasKey(pk => pk.Key);
            builder.Property(p => p.Value).IsRequired();
        }
    }
}
