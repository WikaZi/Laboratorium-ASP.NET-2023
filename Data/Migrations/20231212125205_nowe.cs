using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class nowe : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fb302890-839e-43b4-a5df-8c760e491d9d", "17b9dc9d-6e8f-4bd2-ae06-32d26041c2c6" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fb302890-839e-43b4-a5df-8c760e491d9d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17b9dc9d-6e8f-4bd2-ae06-32d26041c2c6");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "fb302890-839e-43b4-a5df-8c760e491d9d", "fb302890-839e-43b4-a5df-8c760e491d9d", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "17b9dc9d-6e8f-4bd2-ae06-32d26041c2c6", 0, "5bb48b6b-8e45-417e-858f-afa9f3558374", "adam@wsei.pl", true, false, null, "ADAM@WSEI.PL", "ADAM", "AQAAAAEAACcQAAAAENn7rtstVGMjTtQP5JeJnuqwHpO5M7UbvyZ6T7oluWebxfn0RhSjHwAJpQk7Efmr9A==", null, false, "eb779152-bb66-48b4-926d-188515b0bed8", false, "adam" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "fb302890-839e-43b4-a5df-8c760e491d9d", "17b9dc9d-6e8f-4bd2-ae06-32d26041c2c6" });
        }
    }
}
