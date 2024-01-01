using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations.AppDbCMigrations
{
    /// <inheritdoc />
    public partial class users : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "98c71d1e-dc1c-4a21-8926-aef703db202b", "36573f94-d8fe-495b-9e3b-466b698e3cca" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8b2db4ee-e8f1-48a0-8000-9deb8c494baf", "b2025f52-a43d-4470-9684-9599cf2c0fdc" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8b2db4ee-e8f1-48a0-8000-9deb8c494baf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "98c71d1e-dc1c-4a21-8926-aef703db202b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36573f94-d8fe-495b-9e3b-466b698e3cca");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2025f52-a43d-4470-9684-9599cf2c0fdc");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "21162c14-61da-4bd4-9d03-9f224b91d6e8", "21162c14-61da-4bd4-9d03-9f224b91d6e8", "admin", "ADMIN" },
                    { "c809e2b9-a835-4aee-ac6f-5025ccb4b5a2", "c809e2b9-a835-4aee-ac6f-5025ccb4b5a2", "user", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2232ee6f-9e27-4a1f-9de9-1124849b9c53", 0, "973def59-1916-45c0-9e16-2276304893db", "wika@wiw.pl", true, false, null, null, "ADMIN", "AQAAAAEAACcQAAAAEKbM62LDlSizB5k83nJmMuzIwUXv6GBHrWCzpMo++Pxs6Ro76Vc7jizeJU5DyEw1+Q==", null, false, "5fc1c46e-cac0-488d-bc9c-33004a263376", false, "wika" },
                    { "90185a81-3b39-4986-918f-5cd4d91f3532", 0, "133de44b-0142-49f0-aacd-7361d0cc684f", "ola@wiw.pl", true, false, null, null, "USER", "AQAAAAEAACcQAAAAEKsjgZsoS7RJhtWkbNgB55KYzrjE4dxKNt3hb4g0iLbReZqOlYpw37VlzPFkDhZdZA==", null, false, "11812d62-edb3-40c5-ac52-0069f8b933a1", false, "ola" }
                });

            migrationBuilder.UpdateData(
                table: "Licences",
                keyColumn: "Id",
                keyValue: 1,
                column: "ExpirationDate",
                value: new DateTime(2025, 1, 1, 21, 44, 26, 77, DateTimeKind.Local).AddTicks(2842));

            migrationBuilder.UpdateData(
                table: "Licences",
                keyColumn: "Id",
                keyValue: 2,
                column: "ExpirationDate",
                value: new DateTime(2024, 7, 1, 21, 44, 26, 77, DateTimeKind.Local).AddTicks(2877));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "21162c14-61da-4bd4-9d03-9f224b91d6e8", "2232ee6f-9e27-4a1f-9de9-1124849b9c53" },
                    { "c809e2b9-a835-4aee-ac6f-5025ccb4b5a2", "90185a81-3b39-4986-918f-5cd4d91f3532" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "21162c14-61da-4bd4-9d03-9f224b91d6e8", "2232ee6f-9e27-4a1f-9de9-1124849b9c53" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c809e2b9-a835-4aee-ac6f-5025ccb4b5a2", "90185a81-3b39-4986-918f-5cd4d91f3532" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "21162c14-61da-4bd4-9d03-9f224b91d6e8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c809e2b9-a835-4aee-ac6f-5025ccb4b5a2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2232ee6f-9e27-4a1f-9de9-1124849b9c53");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "90185a81-3b39-4986-918f-5cd4d91f3532");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8b2db4ee-e8f1-48a0-8000-9deb8c494baf", "8b2db4ee-e8f1-48a0-8000-9deb8c494baf", "admin", "ADMIN" },
                    { "98c71d1e-dc1c-4a21-8926-aef703db202b", "98c71d1e-dc1c-4a21-8926-aef703db202b", "user", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "36573f94-d8fe-495b-9e3b-466b698e3cca", 0, "ff97bd04-5423-4827-be9b-4b5b53fafc7c", "ola@wiw.pl", true, false, null, null, "USER", "AQAAAAEAACcQAAAAEHaikAsI/GEXHi+xCPGU7SIbyF0J+R+zaSDnXZpKdwUUDX+Ukt1MfD9AHQDa6cJ56Q==", null, false, "720ed0ed-6939-46c2-bb0d-1bf68d3da569", false, "ola" },
                    { "b2025f52-a43d-4470-9684-9599cf2c0fdc", 0, "bc380975-ecb1-4b14-ab39-fcd3860f02e3", "wika@wiw.pl", true, false, null, null, "ADMIN", "AQAAAAEAACcQAAAAEDawNpYJlsvVkNLemV33+mf06pNzaaybwTElEbYRoK/i4Cl8G1x/AlsjleJuNJqsnA==", null, false, "e3ec58cb-a473-4842-868d-f0c2e34db63f", false, "wika" }
                });

            migrationBuilder.UpdateData(
                table: "Licences",
                keyColumn: "Id",
                keyValue: 1,
                column: "ExpirationDate",
                value: new DateTime(2025, 1, 1, 20, 44, 5, 994, DateTimeKind.Local).AddTicks(6222));

            migrationBuilder.UpdateData(
                table: "Licences",
                keyColumn: "Id",
                keyValue: 2,
                column: "ExpirationDate",
                value: new DateTime(2024, 7, 1, 20, 44, 5, 994, DateTimeKind.Local).AddTicks(6263));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "98c71d1e-dc1c-4a21-8926-aef703db202b", "36573f94-d8fe-495b-9e3b-466b698e3cca" },
                    { "8b2db4ee-e8f1-48a0-8000-9deb8c494baf", "b2025f52-a43d-4470-9684-9599cf2c0fdc" }
                });
        }
    }
}
