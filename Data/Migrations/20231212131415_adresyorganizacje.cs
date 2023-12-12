using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class adresyorganizacje : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "60a3947d-25c6-4382-a4d8-a5110b7e1446", "55e2ee30-c8cd-4b6d-98d7-eafae2b9c1d3" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "60a3947d-25c6-4382-a4d8-a5110b7e1446");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "55e2ee30-c8cd-4b6d-98d7-eafae2b9c1d3");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8f9d22cd-76e9-41d0-89af-6740eca029a6", "8f9d22cd-76e9-41d0-89af-6740eca029a6", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "8487695a-a0ba-4082-8b2a-f8ce792785cb", 0, "443e4aac-1444-4a8d-bacf-3f26340b2f5a", "adam@wsei.pl", true, false, null, "ADAM@WSEI.PL", "ADAM", "AQAAAAEAACcQAAAAEGydAdVdFkvpgS2ff7Ijh55k5CQfUnaFOi6J5R1tbjVyqA3tCbNBK/H9fqSJWknRZA==", null, false, "3f8f186c-fde2-4fa3-9d8d-1256b01cf805", false, "adam" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "8f9d22cd-76e9-41d0-89af-6740eca029a6", "8487695a-a0ba-4082-8b2a-f8ce792785cb" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8f9d22cd-76e9-41d0-89af-6740eca029a6", "8487695a-a0ba-4082-8b2a-f8ce792785cb" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8f9d22cd-76e9-41d0-89af-6740eca029a6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8487695a-a0ba-4082-8b2a-f8ce792785cb");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "60a3947d-25c6-4382-a4d8-a5110b7e1446", "60a3947d-25c6-4382-a4d8-a5110b7e1446", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "55e2ee30-c8cd-4b6d-98d7-eafae2b9c1d3", 0, "11f1832b-6943-48b3-a9c2-6899f7bae7a3", "adam@wsei.pl", true, false, null, "ADAM@WSEI.PL", "ADAM", "AQAAAAEAACcQAAAAEHB2v/Zsz361j438vWaidIf6nPyecy+fcRtSnS/yvFkRFRH3TubDLAmCk0ahBf1C0w==", null, false, "7d1d3b08-37c6-4baf-9059-229a9d5dccc3", false, "adam" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "60a3947d-25c6-4382-a4d8-a5110b7e1446", "55e2ee30-c8cd-4b6d-98d7-eafae2b9c1d3" });
        }
    }
}
