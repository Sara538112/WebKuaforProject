using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace b221210566_5_.Migrations
{
    /// <inheritdoc />
    public partial class updatescudule : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "31138b1e-3e46-45fb-aa7f-70e0bd6368d5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6379976d-ae1a-483a-9adb-826cd9b29963");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9689d325-d0e8-4a47-951e-229e55a73022");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bd5e0c66-003a-461e-86be-94ed2170bb23", "4e35d361-1b78-4a3a-928d-ec814e33621e" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd5e0c66-003a-461e-86be-94ed2170bb23");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4e35d361-1b78-4a3a-928d-ec814e33621e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "84a41221-2ffa-478c-a4b4-9fd4b12db92b", null, "Customer", "CUSTOMER" },
                    { "8ba67bcf-afeb-4e4c-aab9-242cc3331986", null, "Admin", "ADMIN" },
                    { "8cc4c8fe-ce59-432f-ac7d-a2af8ccbbc10", null, "Manager", "MANAGER" },
                    { "e8fcedd5-4f83-4f72-9598-f7433a04264f", null, "Employee", "EMPLOYEE" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "433cf001-adaf-4bd9-bb5a-1015bc681177", 0, "8e064ee2-4c3d-407d-bbf4-d402ecfa97a6", "User", "b221210566@ogr.sakarya.edu.tr", true, "Sara", "Mohamed", false, null, "B221210566@OGR.SAKARYA.EDU.TR", null, "AQAAAAIAAYagAAAAEEMQ5AFcjoSOtJO6Z/hELFMUvQDREjdnMk6hMTqlPFj32uwmHNNx3DJwkNRwtrKAUQ==", null, false, "f5061079-c252-4ef6-99c0-852970cfee19", false, null });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "8ba67bcf-afeb-4e4c-aab9-242cc3331986", "433cf001-adaf-4bd9-bb5a-1015bc681177" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "84a41221-2ffa-478c-a4b4-9fd4b12db92b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8cc4c8fe-ce59-432f-ac7d-a2af8ccbbc10");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e8fcedd5-4f83-4f72-9598-f7433a04264f");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8ba67bcf-afeb-4e4c-aab9-242cc3331986", "433cf001-adaf-4bd9-bb5a-1015bc681177" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ba67bcf-afeb-4e4c-aab9-242cc3331986");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "433cf001-adaf-4bd9-bb5a-1015bc681177");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "31138b1e-3e46-45fb-aa7f-70e0bd6368d5", null, "Customer", "CUSTOMER" },
                    { "6379976d-ae1a-483a-9adb-826cd9b29963", null, "Employee", "EMPLOYEE" },
                    { "9689d325-d0e8-4a47-951e-229e55a73022", null, "Manager", "MANAGER" },
                    { "bd5e0c66-003a-461e-86be-94ed2170bb23", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "4e35d361-1b78-4a3a-928d-ec814e33621e", 0, "de9e11d5-574b-4110-ad71-b24b9c6f7918", "User", "b221210566@ogr.sakarya.edu.tr", true, "Sara", "Mohamed", false, null, "B221210566@OGR.SAKARYA.EDU.TR", null, "AQAAAAIAAYagAAAAEOwvgJk/O2tKuAOuXXHkwCt+Ttswak+YckhGUCR7Ha/REp7lRAQtUK2ULG57yMtFUQ==", null, false, "591b9e21-b41f-4432-98fc-e507b080e527", false, null });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "bd5e0c66-003a-461e-86be-94ed2170bb23", "4e35d361-1b78-4a3a-928d-ec814e33621e" });
        }
    }
}
