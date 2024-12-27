using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace b221210566_5_.Migrations
{
    /// <inheritdoc />
    public partial class addEmployeeUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "3e9c3480-daf6-45a8-876f-c15be6d11b07", null, "Manager", "MANAGER" },
                    { "51799150-e9d7-46e2-8cd1-15b8a1d07add", null, "Admin", "ADMIN" },
                    { "9500a75b-16e0-4b2e-81f2-4c3556943b66", null, "Employee", "EMPLOYEE" },
                    { "ed6c03c1-c7ca-4d7c-a183-5639350aac72", null, "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "898b3497-8111-4f6c-832e-2d3b9413fbdf", 0, "efbd1d71-1434-4b2e-80cf-5fd2bec4186d", "User", "b221210566@ogr.sakarya.edu.tr", true, "Sara", "Mohamed", false, null, "B221210566@OGR.SAKARYA.EDU.TR", null, "AQAAAAIAAYagAAAAEP91jYhelJ72p47wLkWZHytQlsVtPPm1/Tl1p4djccQY8t8tq0y+SmY908bgfsQ4cQ==", null, false, "d94c2b5f-728a-4c0c-addc-83a3cc375560", false, null });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "51799150-e9d7-46e2-8cd1-15b8a1d07add", "898b3497-8111-4f6c-832e-2d3b9413fbdf" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e9c3480-daf6-45a8-876f-c15be6d11b07");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9500a75b-16e0-4b2e-81f2-4c3556943b66");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ed6c03c1-c7ca-4d7c-a183-5639350aac72");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "51799150-e9d7-46e2-8cd1-15b8a1d07add", "898b3497-8111-4f6c-832e-2d3b9413fbdf" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "51799150-e9d7-46e2-8cd1-15b8a1d07add");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "898b3497-8111-4f6c-832e-2d3b9413fbdf");

            migrationBuilder.CreateTable(
                name: "UserRegisterDTOs",
                columns: table => new
                {
                    ConfirmPassword = table.Column<string>(type: "text", nullable: false),
                    Department = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false)
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
    }
}
