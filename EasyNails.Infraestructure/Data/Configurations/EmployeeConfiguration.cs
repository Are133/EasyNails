using EasyNails.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace EasyNails.Infraestructure.Data.Configurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employees");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.FirstName)
                .HasColumnName("FirstName")
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.Surname)
                .HasColumnName("Surname")
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.DateOfBirth)
                .HasColumnName("DateOfBirth")
                .HasColumnType("datetime");

            builder.Property(e => e.ImageCertificate)
                .HasColumnName("ImageCertificate")
                .IsRequired()
                .HasMaxLength(500)
                .IsUnicode(false);

            builder.Property(e => e.Address)
                .HasColumnName("Address")
                .IsRequired()
                .HasMaxLength(500)
                .IsUnicode(false);

            builder.Property(e => e.ArrivalTime)
                .HasColumnName("ArrivalTime")
                .HasColumnType("datetime");

            builder.Property(e => e.DepartureTime)
                .HasColumnName("DepartureTime")
                .HasColumnType("datetime");

            builder.Property(e => e.Speciality)
                .HasColumnName("Speciality");

            builder.Property(e => e.Commission)
                .HasColumnName("Commission")
                .HasColumnType("decimal(18,2)");

            builder.Property(e => e.ClientsServed)
                .HasColumnName("ClientsServed");

            builder.Property(e => e.IsActive)
                .HasColumnName("IsActive");

            builder.Property(e => e.NumbersOfDelays)
                .HasColumnName("NumbersOfDelays");

            builder.Property(e => e.NumberOfFaults)
                .HasColumnName("NumberOfFaults");

            builder.Property(e => e.EmployeeId)
                .HasColumnName("EmployeeId")
                .HasMaxLength(500)
                .IsUnicode(false);

        }
    }
}
