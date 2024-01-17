using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations.AppDbCMigrations
{
    /// <inheritdoc />
    public partial class rolaAdm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4e7e18a5-dbb3-4de1-b3fb-579bd7d58544", "d42ef16a-ed37-4ef3-804e-ccdcdd84a01f" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4e7e18a5-dbb3-4de1-b3fb-579bd7d58544");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d42ef16a-ed37-4ef3-804e-ccdcdd84a01f");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "4e7e18a5-dbb3-4de1-b3fb-579bd7d58544", "4e7e18a5-dbb3-4de1-b3fb-579bd7d58544", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "d42ef16a-ed37-4ef3-804e-ccdcdd84a01f", 0, "84469c7d-ec38-4e22-bc32-f68781fe5c14", "wika@wsei.edu.pl", true, false, null, null, "ADMIN", "AQAAAAEAACcQAAAAEEAeDXValOLPiTUsXGJSQKczVruSeWOP5/oA2kHYN8ipw8sYO4z7HvDi3ohgYY53Dg==", null, false, "bc160136-d5cb-4b71-848c-b536c368c070", false, "wika" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "4e7e18a5-dbb3-4de1-b3fb-579bd7d58544", "d42ef16a-ed37-4ef3-804e-ccdcdd84a01f" });
        }
    }
}
