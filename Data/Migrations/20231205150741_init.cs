using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "69b463a5-7f7b-4f67-87bf-2e022c36236a", "0fa17f77-9530-46dd-be01-48e365a9d138" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "69b463a5-7f7b-4f67-87bf-2e022c36236a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0fa17f77-9530-46dd-be01-48e365a9d138");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "69b463a5-7f7b-4f67-87bf-2e022c36236a", "69b463a5-7f7b-4f67-87bf-2e022c36236a", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "0fa17f77-9530-46dd-be01-48e365a9d138", 0, "e2f340f3-c7c2-4703-9036-7d4170460b73", "adam@wsei.pl", true, false, null, "ADAM@WSEI.PL", "ADAM", "AQAAAAEAACcQAAAAEA4a2/Koggv5dQtNBOmHU/4L19tZcI3gQ6fC3qBeYqGgKJvCj2k2x4lOGQ7xtBn2cA==", null, false, "33447b92-e43e-41c3-ba7e-0d9d695fb931", false, "adam" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "69b463a5-7f7b-4f67-87bf-2e022c36236a", "0fa17f77-9530-46dd-be01-48e365a9d138" });
        }
    }
}
