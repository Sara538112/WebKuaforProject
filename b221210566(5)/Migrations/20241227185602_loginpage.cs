using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace b221210566_5_.Migrations
{
    /// <inheritdoc />
    public partial class loginpage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "UserRegisterDTOs",
                columns: table => new
                {
                    Email = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false),
                    ConfirmPassword = table.Column<string>(type: "text", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    Department = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4c4d19a4-030b-4b5f-9713-d7fb7d5f9862", null, "Admin", "ADMIN" },
                    { "596aa8cf-7c3b-45c1-974b-4aae48dc7477", null, "Manager", "MANAGER" },
                    { "a3de0de7-515b-4ade-be45-85054fcaa040", null, "Customer", "CUSTOMER" },
                    { "f9708ff2-b2fd-488c-89a7-d19c28d6a91a", null, "Employee", "EMPLOYEE" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "943473f4-2aad-45ca-8041-40874d3a42b8", 0, "31fd7724-22c5-4ba2-9a1f-f01d26723803", "User", "b221210566@ogr.sakarya.edu.tr", true, "Sara", "Mohamed", false, null, "B221210566@OGR.SAKARYA.EDU.TR", null, "AQAAAAIAAYagAAAAENOgmtXmRNGrxPHlme0TbKWy60cb6J13JPhhSR0lM4xB+I4s4tOu9uIF1rXjk5Xyuw==", null, false, "0c4e6c62-eced-4bfb-b9f4-513cd84db4dd", false, null });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "4c4d19a4-030b-4b5f-9713-d7fb7d5f9862", "943473f4-2aad-45ca-8041-40874d3a42b8" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserRegisterDTOs");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "596aa8cf-7c3b-45c1-974b-4aae48dc7477");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a3de0de7-515b-4ade-be45-85054fcaa040");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f9708ff2-b2fd-488c-89a7-d19c28d6a91a");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4c4d19a4-030b-4b5f-9713-d7fb7d5f9862", "943473f4-2aad-45ca-8041-40874d3a42b8" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4c4d19a4-030b-4b5f-9713-d7fb7d5f9862");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "943473f4-2aad-45ca-8041-40874d3a42b8");

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
    }
}
