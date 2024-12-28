﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace b221210566_5_.Migrations
{
    /// <inheritdoc />
    public partial class LastUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "2498bcb2-99b4-4268-99d7-7dc72c3720c4", null, "Employee", "EMPLOYEE" },
                    { "55ff4d55-f823-464b-9906-f7c0f4a1b174", null, "Customer", "CUSTOMER" },
                    { "66e0a493-71d4-420e-b5cf-dbd0be8fed3b", null, "Manager", "MANAGER" },
                    { "9771c6aa-31b5-4e55-ae82-1421147c40cf", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2498bcb2-99b4-4268-99d7-7dc72c3720c4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "55ff4d55-f823-464b-9906-f7c0f4a1b174");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "66e0a493-71d4-420e-b5cf-dbd0be8fed3b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9771c6aa-31b5-4e55-ae82-1421147c40cf");

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
    }
}
