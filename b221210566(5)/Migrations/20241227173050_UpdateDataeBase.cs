using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace b221210566_5_.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDataeBase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3f50b4fe-3eee-4029-a945-1e270a7ea87b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c54c5a1b-e38b-4c68-a095-3f40b4766104");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cb3c3a83-e54d-4b58-bcc9-9d4990dd64b4");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "73b478fe-7bd3-4201-956c-828fd892200c", "01ce0642-e1bb-43e8-9548-310d7dce2887" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73b478fe-7bd3-4201-956c-828fd892200c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "01ce0642-e1bb-43e8-9548-310d7dce2887");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "17ffef23-e0ef-44fb-8ebf-c9fe4ffac99b", null, "Customer", "CUSTOMER" },
                    { "28819049-8f9a-46c5-ae54-33fc036dcf70", null, "Manager", "MANAGER" },
                    { "6fc177f8-8f8c-4f9b-81c8-60d124635555", null, "Admin", "ADMIN" },
                    { "df082696-3aff-4b20-afea-548bff53a46b", null, "Employee", "EMPLOYEE" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e75c35ca-332a-4e83-beda-289db9b71fc9", 0, "14c8bfbe-3e9e-4e77-954a-f5d4d41d2349", "User", "b221210566@ogr.sakarya.edu.tr", true, "Sara", "Mohamed", false, null, "B221210566@OGR.SAKARYA.EDU.TR", null, "AQAAAAIAAYagAAAAEKtxurJgdZ9Bt0n3M8TY0lJWQ1RENuvZhaj0h6eZIB61nRBmKAPqdVV8XLIsAstB5g==", null, false, "f7cba468-3264-4848-a8e0-fefb60612647", false, null });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "6fc177f8-8f8c-4f9b-81c8-60d124635555", "e75c35ca-332a-4e83-beda-289db9b71fc9" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "17ffef23-e0ef-44fb-8ebf-c9fe4ffac99b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "28819049-8f9a-46c5-ae54-33fc036dcf70");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "df082696-3aff-4b20-afea-548bff53a46b");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6fc177f8-8f8c-4f9b-81c8-60d124635555", "e75c35ca-332a-4e83-beda-289db9b71fc9" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6fc177f8-8f8c-4f9b-81c8-60d124635555");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e75c35ca-332a-4e83-beda-289db9b71fc9");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3f50b4fe-3eee-4029-a945-1e270a7ea87b", null, "Employee", "EMPLOYEE" },
                    { "73b478fe-7bd3-4201-956c-828fd892200c", null, "Admin", "ADMIN" },
                    { "c54c5a1b-e38b-4c68-a095-3f40b4766104", null, "Customer", "CUSTOMER" },
                    { "cb3c3a83-e54d-4b58-bcc9-9d4990dd64b4", null, "Manager", "MANAGER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "01ce0642-e1bb-43e8-9548-310d7dce2887", 0, "09fb7ff4-83ef-4d5d-a59c-79003893e4a3", "User", "b221210566@ogr.sakarya.edu.tr", true, "Sara", "Mohamed", false, null, "B221210566@OGR.SAKARYA.EDU.TR", null, "AQAAAAIAAYagAAAAEF3yIWHfTRdu+ItOUItULnJWeeedj/L1gv/wQ27AM5N+lo8G6XsDev8N+SOrUh/57w==", null, false, "b49dbf8c-6f3d-4a15-bd63-8a3eb89f6833", false, null });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "73b478fe-7bd3-4201-956c-828fd892200c", "01ce0642-e1bb-43e8-9548-310d7dce2887" });
        }
    }
}
