using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class dane : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "c7fef1b8-8074-4876-9787-0efcae776a75", "c7fef1b8-8074-4876-9787-0efcae776a75", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "41a87921-088b-48d5-a09a-dc539377e58e", 0, "e612583e-f694-40b3-a23a-8cf7a63068f8", "adam@wsei.pl", true, false, null, "ADAM@WSEI.PL", "ADAM", "AQAAAAEAACcQAAAAECntrFeYTsMaY7AukQVydX7diakpzsGiildfXIbSeFxH7A7UZ/s4tn0bGI1hxt8ZEA==", null, false, "15b8c864-7f95-423c-a1da-824ad8ad56d5", false, "adam" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "c7fef1b8-8074-4876-9787-0efcae776a75", "41a87921-088b-48d5-a09a-dc539377e58e" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c7fef1b8-8074-4876-9787-0efcae776a75", "41a87921-088b-48d5-a09a-dc539377e58e" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c7fef1b8-8074-4876-9787-0efcae776a75");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41a87921-088b-48d5-a09a-dc539377e58e");

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
    }
}
