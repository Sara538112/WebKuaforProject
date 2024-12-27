using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace b221210566_5_.Migrations
{
    /// <inheritdoc />
    public partial class newDataBase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "43777f7d-9bad-4506-933a-ee54168cb780");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9faa8091-074f-42c9-bd4a-72755d775f5c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd50b9c6-4e71-4057-9a47-27976c612468");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ffee8aa7-b3f3-49d4-8b18-3125cddee957", "8f2fc702-25ee-4d87-a528-986575ecefcb" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ffee8aa7-b3f3-49d4-8b18-3125cddee957");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8f2fc702-25ee-4d87-a528-986575ecefcb");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "43777f7d-9bad-4506-933a-ee54168cb780", null, "Employee", "EMPLOYEE" },
                    { "9faa8091-074f-42c9-bd4a-72755d775f5c", null, "Manager", "MANAGER" },
                    { "bd50b9c6-4e71-4057-9a47-27976c612468", null, "Customer", "CUSTOMER" },
                    { "ffee8aa7-b3f3-49d4-8b18-3125cddee957", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "8f2fc702-25ee-4d87-a528-986575ecefcb", 0, "2ff001d1-b0d5-40c5-af9a-81e2e643272b", "User", "b221210566@ogr.sakarya.edu.tr", true, "Sara", "Mohamed", false, null, "b221210566@ogr.sakarya.edu.tr", "SaraMohamed", "AQAAAAIAAYagAAAAEFpR5dR7g804J7zcoZdPLdehr9l6gzS5QLw75eRmoOVr+gyONc79xUR/c9jd0tSBpw==", null, false, "73d03dd9-a6a1-4c60-acb5-6a5db87df91a", false, "Sara Mohamed" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ffee8aa7-b3f3-49d4-8b18-3125cddee957", "8f2fc702-25ee-4d87-a528-986575ecefcb" });
        }
    }
}
