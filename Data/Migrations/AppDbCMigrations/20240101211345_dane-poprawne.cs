using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations.AppDbCMigrations
{
    /// <inheritdoc />
    public partial class danepoprawne : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[,]
                {
                    { "a44b6daf-00c0-4404-8db9-04b516c15598", "a44b6daf-00c0-4404-8db9-04b516c15598", "admin", "ADMIN" },
                    { "e5b196c8-912a-4c8d-acf4-6808ca8d81f5", "e5b196c8-912a-4c8d-acf4-6808ca8d81f5", "user", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "7bbd2f4c-0081-4604-ad5a-d06faa3fb08f", 0, "3bd80aeb-d050-4ef9-a103-f117fb8c8457", "adam@wsei.pl", true, false, null, "ADAM@WSEI.PL", "ADAM", "AQAAAAEAACcQAAAAEOOrxOPrchK7ocLcpaqCTRR6jFvMRj9yF5SeIf0gv9MWLe1NIhwYS6yxOQIMlGCnEQ==", null, false, "1613a60f-e9fb-47a1-9dac-3041b259f72c", false, "adam" },
                    { "ae39cd25-abd1-4982-b813-1eeca5ab9a30", 0, "9c380669-b071-400f-9b1b-cf52d093e886", "wika@wsei.pl", true, false, null, "WIKA@WSEI.PL", "WIKA", "AQAAAAEAACcQAAAAEKylrWCkqwKiJvlHEjO9XOYJu2EPSDdmAKwFQ9nsNaJuGvDzmD/WxnJHtTNtFTYEmg==", null, false, "1d318f4b-3242-4641-ae77-dfd28d470bfb", false, "wika" }
                });

            migrationBuilder.UpdateData(
                table: "Licences",
                keyColumn: "Id",
                keyValue: 1,
                column: "ExpirationDate",
                value: new DateTime(2025, 1, 1, 22, 13, 45, 750, DateTimeKind.Local).AddTicks(2252));

            migrationBuilder.UpdateData(
                table: "Licences",
                keyColumn: "Id",
                keyValue: 2,
                column: "ExpirationDate",
                value: new DateTime(2024, 7, 1, 22, 13, 45, 750, DateTimeKind.Local).AddTicks(2284));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "a44b6daf-00c0-4404-8db9-04b516c15598", "7bbd2f4c-0081-4604-ad5a-d06faa3fb08f" },
                    { "e5b196c8-912a-4c8d-acf4-6808ca8d81f5", "ae39cd25-abd1-4982-b813-1eeca5ab9a30" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a44b6daf-00c0-4404-8db9-04b516c15598", "7bbd2f4c-0081-4604-ad5a-d06faa3fb08f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e5b196c8-912a-4c8d-acf4-6808ca8d81f5", "ae39cd25-abd1-4982-b813-1eeca5ab9a30" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a44b6daf-00c0-4404-8db9-04b516c15598");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e5b196c8-912a-4c8d-acf4-6808ca8d81f5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7bbd2f4c-0081-4604-ad5a-d06faa3fb08f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ae39cd25-abd1-4982-b813-1eeca5ab9a30");

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
    }
}
