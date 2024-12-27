using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace b221210566_5_.Migrations
{
    /// <inheritdoc />
    public partial class updateadmin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd03fb15-4bad-444e-8d7c-ab17f4af30a8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d123b585-4b3a-4b1a-93ff-64fe9b849369");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d28305ea-d5c5-4552-b618-1b3386aa6a4c");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cb7a750e-5974-48d9-ae4f-3ef97e126efc", "5a7927bd-01b5-4b41-859d-3e17f9376f79" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cb7a750e-5974-48d9-ae4f-3ef97e126efc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5a7927bd-01b5-4b41-859d-3e17f9376f79");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "bd03fb15-4bad-444e-8d7c-ab17f4af30a8", null, "Customer", "CUSTOMER" },
                    { "cb7a750e-5974-48d9-ae4f-3ef97e126efc", null, "Admin", "ADMIN" },
                    { "d123b585-4b3a-4b1a-93ff-64fe9b849369", null, "Manager", "MANAGER" },
                    { "d28305ea-d5c5-4552-b618-1b3386aa6a4c", null, "Employee", "EMPLOYEE" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "5a7927bd-01b5-4b41-859d-3e17f9376f79", 0, "e69f341a-6348-4e67-adc1-ee1dcc19883f", "User", "b221210566@ogr.sakarya.edu.tr", true, "Sara", "Mohamed", false, null, "b221210566@ogr.sakarya.edu.tr", "SaraMohamed", "AQAAAAIAAYagAAAAEJNR4qW2hLJitdgpHVoAxN3HHy6oOfvsS7zAy/U8xVB/qcsqO7h+Jr2jX+VPUoYYXg==", null, false, "cc240e93-7f67-4a95-aabc-3bcbd5615316", false, "Sara Mohamed" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cb7a750e-5974-48d9-ae4f-3ef97e126efc", "5a7927bd-01b5-4b41-859d-3e17f9376f79" });
        }
    }
}
