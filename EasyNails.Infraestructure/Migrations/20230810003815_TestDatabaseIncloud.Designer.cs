﻿// <auto-generated />
using System;
using EasyNails.Infraestructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EasyNails.Infraestructure.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230810003815_TestDatabaseIncloud")]
    partial class TestDatabaseIncloud
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EasyNails.Core.Entities.Branch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnName("Address")
                        .HasColumnType("varchar(500)")
                        .HasMaxLength(500)
                        .IsUnicode(false);

                    b.Property<string>("BranchGuidId")
                        .IsRequired()
                        .HasColumnName("BranchGuidId")
                        .HasColumnType("varchar(500)")
                        .HasMaxLength(500)
                        .IsUnicode(false);

                    b.Property<bool>("IsActive")
                        .HasColumnName("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("Name")
                        .HasColumnType("varchar(500)")
                        .HasMaxLength(500)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("Branch");
                });

            modelBuilder.Entity("EasyNails.Core.Entities.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnName("Address")
                        .HasColumnType("varchar(500)")
                        .HasMaxLength(500)
                        .IsUnicode(false);

                    b.Property<DateTime>("ArrivalTime")
                        .HasColumnName("ArrivalTime")
                        .HasColumnType("datetime");

                    b.Property<int>("BranchId")
                        .HasColumnType("int");

                    b.Property<int>("ClientsServed")
                        .HasColumnName("ClientsServed")
                        .HasColumnType("int");

                    b.Property<decimal>("Commission")
                        .HasColumnName("Commission")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnName("DateOfBirth")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("DepartureTime")
                        .HasColumnName("DepartureTime")
                        .HasColumnType("datetime");

                    b.Property<string>("EmployeeId")
                        .IsRequired()
                        .HasColumnName("EmployeeId")
                        .HasColumnType("varchar(500)")
                        .HasMaxLength(500)
                        .IsUnicode(false);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnName("FirstName")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("ImageCertificate")
                        .IsRequired()
                        .HasColumnName("ImageCertificate")
                        .HasColumnType("varchar(500)")
                        .HasMaxLength(500)
                        .IsUnicode(false);

                    b.Property<bool>("IsActive")
                        .HasColumnName("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("NumberOfFaults")
                        .HasColumnName("NumberOfFaults")
                        .HasColumnType("int");

                    b.Property<int>("NumbersOfDelays")
                        .HasColumnName("NumbersOfDelays")
                        .HasColumnType("int");

                    b.Property<int>("Speciality")
                        .HasColumnName("Speciality")
                        .HasColumnType("int");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnName("Surname")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.HasIndex("BranchId");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("EasyNails.Core.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("Email")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnName("FirstName")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnName("Password")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("EasyNails.Core.Entities.Employee", b =>
                {
                    b.HasOne("EasyNails.Core.Entities.Branch", "Branch")
                        .WithMany()
                        .HasForeignKey("BranchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
