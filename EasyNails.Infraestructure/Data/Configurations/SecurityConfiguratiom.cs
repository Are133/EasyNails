using EasyNails.Core.Entities;
using EasyNails.Core.Enumerations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace EasyNails.Infraestructure.Data.Configurations
{
    public class SecurityConfiguratiom : IEntityTypeConfiguration<Security>
    {
        public void Configure(EntityTypeBuilder<Security> builder)
        {
            builder.ToTable("Security");

            builder.HasKey(b => b.Id);

            builder.Property(b => b.User)
               .HasColumnName("User")
               .HasMaxLength(500)
               .IsUnicode(false);

            builder.Property(b => b.Username)
               .HasColumnName("Username")
               .HasMaxLength(500)
               .IsUnicode(false);

            builder.Property(b => b.Password)
               .HasColumnName("Password")
               .HasMaxLength(500)
               .IsUnicode(false);

            builder.Property(b => b.Role)
               .HasColumnName("Role")
               .HasMaxLength(500)
               .IsUnicode(false).HasConversion(rt => rt.ToString(),
               rt => (RoleType)Enum.Parse(typeof(RoleType), rt));

            builder.Property(b => b.IsActive)
                .HasColumnName("IsActive");
        }
    }
}
