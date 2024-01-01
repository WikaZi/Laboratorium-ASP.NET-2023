using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations.AppDbCMigrations
{
    /// <inheritdoc />
    public partial class softwares : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AddColumn<int>(
                name: "SoftwareId",
                table: "Computers",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Softwares",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Version = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Softwares", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ComputerEntitySoftwareEntity",
                columns: table => new
                {
                    ComputersId = table.Column<int>(type: "INTEGER", nullable: false),
                    SoftwaresId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComputerEntitySoftwareEntity", x => new { x.ComputersId, x.SoftwaresId });
                    table.ForeignKey(
                        name: "FK_ComputerEntitySoftwareEntity_Computers_ComputersId",
                        column: x => x.ComputersId,
                        principalTable: "Computers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ComputerEntitySoftwareEntity_Softwares_SoftwaresId",
                        column: x => x.SoftwaresId,
                        principalTable: "Softwares",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Licences",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LicenseKey = table.Column<string>(type: "TEXT", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    LicenseType = table.Column<string>(type: "TEXT", nullable: false),
                    ComputerId = table.Column<int>(type: "INTEGER", nullable: false),
                    SoftwareId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Licences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Licences_Computers_ComputerId",
                        column: x => x.ComputerId,
                        principalTable: "Computers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Licences_Softwares_SoftwareId",
                        column: x => x.SoftwareId,
                        principalTable: "Softwares",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Computers",
                columns: new[] { "Id", "DateOfProduction", "GraphicsCard", "Memory", "Name", "Processor", "Producer", "SoftwareId" },
                values: new object[,]
                {
                    { 123, new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "RTX-4060Ti", "32GB", "G4MR-HERO", "i7-13700F", "6253efvdfEr2", 1 },
                    { 223, new DateTime(2023, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "RTX-4070", "64GB", "POW3R-HUGE", "i9-11900K", "MAVIS-PR", 2 }
                });

            migrationBuilder.InsertData(
                table: "Softwares",
                columns: new[] { "Id", "Name", "Version" },
                values: new object[,]
                {
                    { 1, "Microsoft Office", "365" },
                    { 2, "Windows 10", "20H2" },
                    { 3, "Visual Studio Code", "1.50.1" }
                });

            migrationBuilder.InsertData(
                table: "ComputerEntitySoftwareEntity",
                columns: new[] { "ComputersId", "SoftwaresId" },
                values: new object[,]
                {
                    { 123, 1 },
                    { 223, 2 }
                });

            migrationBuilder.InsertData(
                table: "Licences",
                columns: new[] { "Id", "ComputerId", "ExpirationDate", "LicenseKey", "LicenseType", "SoftwareId" },
                values: new object[,]
                {
                    { 1, 123, new DateTime(2025, 1, 1, 18, 41, 30, 924, DateTimeKind.Local).AddTicks(1092), "ABAB1212", "Bussiness", 1 },
                    { 2, 223, new DateTime(2024, 7, 1, 18, 41, 30, 924, DateTimeKind.Local).AddTicks(1125), "MI45-L", "Home", 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ComputerEntitySoftwareEntity_SoftwaresId",
                table: "ComputerEntitySoftwareEntity",
                column: "SoftwaresId");

            migrationBuilder.CreateIndex(
                name: "IX_Licences_ComputerId",
                table: "Licences",
                column: "ComputerId");

            migrationBuilder.CreateIndex(
                name: "IX_Licences_SoftwareId",
                table: "Licences",
                column: "SoftwareId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ComputerEntitySoftwareEntity");

            migrationBuilder.DropTable(
                name: "Licences");

            migrationBuilder.DropTable(
                name: "Softwares");

            migrationBuilder.DeleteData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DropColumn(
                name: "SoftwareId",
                table: "Computers");

            migrationBuilder.InsertData(
                table: "Computers",
                columns: new[] { "Id", "DateOfProduction", "GraphicsCard", "Memory", "Name", "Processor", "Producer" },
                values: new object[] { 1, new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "RTX-4060Ti", "32GB", "G4MR-HERO", "i7-13700F", "6253efvdfEr2" });
        }
    }
}
