using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoffeApi.Migrations
{
    public partial class InitCoffes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CoffeSM",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(36)", unicode: false, maxLength: 36, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Category = table.Column<byte>(type: "tinyint", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoffeSM", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "CoffeSM",
                columns: new[] { "Id", "Category", "Code", "CreatedOn", "Name", "Price" },
                values: new object[] { "52494a78-461a-4bb6-86bb-0bafe5ad744e", (byte)2, "CFF002", new DateTime(2023, 12, 11, 8, 49, 54, 961, DateTimeKind.Local).AddTicks(780), "Ice Latte", 4.0 });

            migrationBuilder.InsertData(
                table: "CoffeSM",
                columns: new[] { "Id", "Category", "Code", "CreatedOn", "Name", "Price" },
                values: new object[] { "5f947261-8082-44bb-9f8d-6fc4f029bac3", (byte)1, "CFF003", new DateTime(2023, 12, 11, 8, 49, 54, 961, DateTimeKind.Local).AddTicks(800), "Hot Latte", 5.0 });

            migrationBuilder.InsertData(
                table: "CoffeSM",
                columns: new[] { "Id", "Category", "Code", "CreatedOn", "Name", "Price" },
                values: new object[] { "fc1ec19b-ac51-48bb-b16f-1ec6c15332ae", (byte)1, "CFF001", new DateTime(2023, 12, 11, 8, 49, 54, 961, DateTimeKind.Local).AddTicks(754), "Moca", 3.0 });

            migrationBuilder.CreateIndex(
                name: "IX_CoffeSM_Code",
                table: "CoffeSM",
                column: "Code",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CoffeSM");
        }
    }
}
