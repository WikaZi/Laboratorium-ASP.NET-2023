using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations.AppDbCMigrations
{
    /// <inheritdoc />
    public partial class rolaU : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "94bf2c35-4d95-4c6d-b60a-73fc6b646865", "bf470b4e-9d04-4fd4-95ba-3177c4d0955b" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "94bf2c35-4d95-4c6d-b60a-73fc6b646865");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bf470b4e-9d04-4fd4-95ba-3177c4d0955b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "37866e0b-9628-472a-aafe-0d5d8a00ec01", "37866e0b-9628-472a-aafe-0d5d8a00ec01", "user", "USER" },
                    { "4c1eda49-773b-4913-8f93-83e2c31c03fd", "4c1eda49-773b-4913-8f93-83e2c31c03fd", "admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "b748383c-6387-4ad5-98e7-e8472693d5f1", 0, "78216894-fb72-4bb9-b9f0-79d9fbdf6eda", "wika@wsei.pl", true, false, null, "WIKA@WSEI.PL", "WIKA", "AQAAAAEAACcQAAAAEC/SU+nLPRnAnpNpQaBcLJdLwqLdzGRTWChrPBjLG045in63UAfttFVdvNwsYrfnbQ==", null, false, "db185948-8ba7-42f9-8e0e-6282999e2dbd", false, "wika" },
                    { "ec47d446-64ae-46d9-9318-300fd3d7906c", 0, "c7f04f00-1c7e-45a3-a4cf-27340b00ffd6", "nikola@wsei.pl", true, false, null, "NIKOLA@WSEI.PL", "NIKOLA", "AQAAAAEAACcQAAAAEK/RsOP2cjyQf45TMA1J75EW/IhL71DzFu4qUw71zWfxQk0DNjz7pD4B6UUPiwi34A==", null, false, "db35c41f-8076-4576-98f3-dee981fac25f", false, "nikola" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "4c1eda49-773b-4913-8f93-83e2c31c03fd", "b748383c-6387-4ad5-98e7-e8472693d5f1" },
                    { "37866e0b-9628-472a-aafe-0d5d8a00ec01", "ec47d446-64ae-46d9-9318-300fd3d7906c" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4c1eda49-773b-4913-8f93-83e2c31c03fd", "b748383c-6387-4ad5-98e7-e8472693d5f1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "37866e0b-9628-472a-aafe-0d5d8a00ec01", "ec47d446-64ae-46d9-9318-300fd3d7906c" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "37866e0b-9628-472a-aafe-0d5d8a00ec01");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4c1eda49-773b-4913-8f93-83e2c31c03fd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b748383c-6387-4ad5-98e7-e8472693d5f1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ec47d446-64ae-46d9-9318-300fd3d7906c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "94bf2c35-4d95-4c6d-b60a-73fc6b646865", "94bf2c35-4d95-4c6d-b60a-73fc6b646865", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "bf470b4e-9d04-4fd4-95ba-3177c4d0955b", 0, "21b9adcf-5cd2-4590-bfa9-409b702dc7fa", "wika@wsei.pl", true, false, null, "WIKA@WSEI.PL", "WIKA", "AQAAAAEAACcQAAAAEHLEov0KzeVIAA7HOOQRDbNpfea55aBC6ynwXzAYzzA60fHOQF+z6xQc+i2s/Y4QMQ==", null, false, "cc419da3-a324-432a-b581-4975fb380b4e", false, "wika" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "94bf2c35-4d95-4c6d-b60a-73fc6b646865", "bf470b4e-9d04-4fd4-95ba-3177c4d0955b" });
        }
    }
}
