using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations.AppDbCMigrations
{
    /// <inheritdoc />
    public partial class newC : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 123,
                column: "SoftwareId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 223,
                column: "SoftwareId",
                value: null);

            migrationBuilder.InsertData(
                table: "Computers",
                columns: new[] { "Id", "DateOfProduction", "GraphicsCard", "Memory", "Name", "Processor", "Producer", "SoftwareId" },
                values: new object[] { 22, new DateTime(2013, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "RTX-4060TI", "128GB", "D3MOGA-23", "i9-13700K", "XAMI", null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 123,
                column: "SoftwareId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 223,
                column: "SoftwareId",
                value: 2);
        }
    }
}
