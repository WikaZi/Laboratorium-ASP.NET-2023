using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations.AppDbCMigrations
{
    /// <inheritdoc />
    public partial class popusers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "401c1507-fc76-43f2-bbc9-c923f7098e92", "e259eea3-9a49-4c11-9edf-0d5db88cd749" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "401c1507-fc76-43f2-bbc9-c923f7098e92");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e259eea3-9a49-4c11-9edf-0d5db88cd749");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "bf85911a-5257-464e-bbbb-2542c8f1f105", "5f0bf86c-1fce-4a10-9e6a-c380f7bd6c43", "user", "USER" },
                    { "f7d5f704-4237-4131-8f8b-3bdf06528f61", "f7d5f704-4237-4131-8f8b-3bdf06528f61", "admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3cfa1415-6558-4431-9b5d-3b75f8006795", 0, "9a313d1e-a8ca-4acd-8a82-076dcd5fa82a", "adam@wsei.pl", true, false, null, "ADAM@WSEI.PL", "ADAM", "AQAAAAEAACcQAAAAEPO3R9SBScGwbkZDEsivJAN7/Kbsun9+KzvpuEZxoIFf2f4AJdLUBtUknYfdrpitCw==", null, false, "be90fd8f-e6c8-490d-a25b-e57fd08d8be5", false, "adam" },
                    { "af6e98ca-8762-4848-92c0-79872338c73e", 0, "9ea86cc7-e17d-4454-badd-856d70ee2d3e", "wika@wsei.pl", true, false, null, "WIKA@WSEI.PL", "WIKA", "AQAAAAEAACcQAAAAEAS5X2FwdGVVt9yYLb3RH353VPlWp5gYfQAxqi7WDWTr9u2zgZXAhdU1g9mjRNIRmQ==", null, false, "445e8043-3d8a-4abe-a2ce-d9c0a1c565ca", false, "wika" }
                });

            migrationBuilder.UpdateData(
                table: "Licences",
                keyColumn: "Id",
                keyValue: 1,
                column: "ExpirationDate",
                value: new DateTime(2025, 1, 1, 22, 2, 14, 712, DateTimeKind.Local).AddTicks(2201));

            migrationBuilder.UpdateData(
                table: "Licences",
                keyColumn: "Id",
                keyValue: 2,
                column: "ExpirationDate",
                value: new DateTime(2024, 7, 1, 22, 2, 14, 712, DateTimeKind.Local).AddTicks(2236));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "f7d5f704-4237-4131-8f8b-3bdf06528f61", "3cfa1415-6558-4431-9b5d-3b75f8006795" },
                    { "bf85911a-5257-464e-bbbb-2542c8f1f105", "af6e98ca-8762-4848-92c0-79872338c73e" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f7d5f704-4237-4131-8f8b-3bdf06528f61", "3cfa1415-6558-4431-9b5d-3b75f8006795" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bf85911a-5257-464e-bbbb-2542c8f1f105", "af6e98ca-8762-4848-92c0-79872338c73e" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf85911a-5257-464e-bbbb-2542c8f1f105");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f7d5f704-4237-4131-8f8b-3bdf06528f61");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3cfa1415-6558-4431-9b5d-3b75f8006795");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "af6e98ca-8762-4848-92c0-79872338c73e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "401c1507-fc76-43f2-bbc9-c923f7098e92", "401c1507-fc76-43f2-bbc9-c923f7098e92", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e259eea3-9a49-4c11-9edf-0d5db88cd749", 0, "51daeb41-0a4a-4ba9-9181-be373ad64d29", "wika@wsei.pl", true, false, null, "WIKA@WSEI.PL", "WIKA", "AQAAAAEAACcQAAAAEHu5ITV+pVNV2DcKVAVaxssimwwTMvjOjmju1G8mv18pQGLQ6U1ZVgokRIXggx8Pog==", null, false, "337903f8-cffc-432e-9cf9-538f0891e3cd", false, "wika" });

            migrationBuilder.UpdateData(
                table: "Licences",
                keyColumn: "Id",
                keyValue: 1,
                column: "ExpirationDate",
                value: new DateTime(2025, 1, 1, 21, 54, 44, 680, DateTimeKind.Local).AddTicks(3947));

            migrationBuilder.UpdateData(
                table: "Licences",
                keyColumn: "Id",
                keyValue: 2,
                column: "ExpirationDate",
                value: new DateTime(2024, 7, 1, 21, 54, 44, 680, DateTimeKind.Local).AddTicks(3979));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "401c1507-fc76-43f2-bbc9-c923f7098e92", "e259eea3-9a49-4c11-9edf-0d5db88cd749" });
        }
    }
}
