using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace b221210566_5_.Migrations
{
    /// <inheritdoc />
    public partial class updateAppEmployee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "AvaliableTime",
                table: "appointmentEmployees");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "AvaliableTime",
                table: "appointmentEmployees",
                type: "text",
                nullable: false,
                defaultValue: "");

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
    }
}
