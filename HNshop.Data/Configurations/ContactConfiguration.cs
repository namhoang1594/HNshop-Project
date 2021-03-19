using HNshop.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HNshop.Data.Configurations
{
    public class ContactConfiguration : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.ToTable("Contacts");
            builder.HasKey(pk => pk.Id);
            builder.Property(p => p.Id).UseIdentityColumn();
            builder.Property(p => p.Name).IsRequired().HasMaxLength(200);
            builder.Property(p => p.Email).IsRequired().HasMaxLength(200);
            builder.Property(p => p.PhoneNumber).IsRequired().HasMaxLength(200);
            builder.Property(p => p.Message).IsRequired();
        }
    }
}
