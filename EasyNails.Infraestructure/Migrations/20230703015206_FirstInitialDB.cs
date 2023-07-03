using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EasyNails.Infraestructure.Migrations
{
    public partial class FirstInitialDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    Surname = table.Column<string>(nullable: false),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    ImageCertificate = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: false),
                    ArrivalTime = table.Column<DateTime>(nullable: false),
                    DepartureTime = table.Column<DateTime>(nullable: false),
                    Speciality = table.Column<int>(nullable: false),
                    Commission = table.Column<decimal>(nullable: false),
                    ClientsServed = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    NumbersOfDelays = table.Column<int>(nullable: false),
                    NumberOfFaults = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
