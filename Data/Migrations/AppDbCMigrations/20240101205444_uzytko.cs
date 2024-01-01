using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations.AppDbCMigrations
{
    /// <inheritdoc />
    public partial class uzytko : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
