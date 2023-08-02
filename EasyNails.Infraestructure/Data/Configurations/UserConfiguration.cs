using EasyNails.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyNails.Infraestructure.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");

            builder.HasKey(u => u.Id);

            builder.Property(u => u.FirstName).HasColumnName("FirstName")
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(u => u.Password).HasColumnName("Password")
               .IsRequired()
               .HasMaxLength(50)
               .IsUnicode(false);

            builder.Property(u => u.Email).HasColumnName("Email")
               .IsRequired()
               .HasMaxLength(50)
               .IsUnicode(false);
        }
    }
}
