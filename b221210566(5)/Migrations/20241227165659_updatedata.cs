using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace b221210566_5_.Migrations
{
    /// <inheritdoc />
    public partial class updatedata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0275d911-2625-48cf-a193-2f55c25f252b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "096a773f-325e-4a61-9d2b-d7fa83852822");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5e69b946-71a9-4575-af83-28c3d2700ab1");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "19b9e73e-9520-490f-9d98-0113c800ec2b", "f61393b4-88c8-40a2-a67d-66573d971705" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "19b9e73e-9520-490f-9d98-0113c800ec2b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f61393b4-88c8-40a2-a67d-66573d971705");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "0275d911-2625-48cf-a193-2f55c25f252b", null, "Employee", "EMPLOYEE" },
                    { "096a773f-325e-4a61-9d2b-d7fa83852822", null, "Customer", "CUSTOMER" },
                    { "19b9e73e-9520-490f-9d98-0113c800ec2b", null, "Admin", "ADMIN" },
                    { "5e69b946-71a9-4575-af83-28c3d2700ab1", null, "Manager", "MANAGER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f61393b4-88c8-40a2-a67d-66573d971705", 0, "783431d1-7f6f-4408-8026-b8f3762e189c", "User", "b221210566@ogr.sakarya.edu.tr", true, "Sara", "Mohamed", false, null, "B221210566@OGR.SAKARYA.EDU.TR", "SARAMOHAMED", "AQAAAAIAAYagAAAAEM2HBbv7MiTPb7LJPBkqlK8dGwXohbx0lNV80/3tu2q37CoMD2o/6lnhIa7c/wUoZA==", null, false, "b12811ce-19f7-4019-a8e7-cf8a0859d934", false, "Sara Mohamed" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "19b9e73e-9520-490f-9d98-0113c800ec2b", "f61393b4-88c8-40a2-a67d-66573d971705" });
        }
    }
}
