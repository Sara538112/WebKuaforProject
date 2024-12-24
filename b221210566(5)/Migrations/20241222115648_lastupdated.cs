using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace b221210566_5_.Migrations
{
    /// <inheritdoc />
    public partial class lastupdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_appointments_AspNetUsers_EmployeeId",
                table: "appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_appointments_AspNetUsers_EmployeeId1",
                table: "appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_AspNetUsers_ManagerId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_AspNetUsers_ManagerId1",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_ManagerId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_ManagerId1",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_appointments_EmployeeId",
                table: "appointments");

            migrationBuilder.DropIndex(
                name: "IX_appointments_EmployeeId1",
                table: "appointments");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3a28b3a5-0f1c-4be4-b298-4bea3acab5c9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "71218633-20bc-4c82-a1b5-cdc5c8688a04");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "77114515-3f20-4517-8ee9-f5be9108095e");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "205ef2fe-b916-4975-8091-926f4c7a5bba", "5b5733fc-a5e3-4ceb-8edf-49f43ef22307" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "205ef2fe-b916-4975-8091-926f4c7a5bba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5b5733fc-a5e3-4ceb-8edf-49f43ef22307");

            migrationBuilder.DropColumn(
                name: "ManagerId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ManagerId1",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "appointments");

            migrationBuilder.DropColumn(
                name: "EmployeeId1",
                table: "appointments");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "appointments",
                type: "text",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "appointmentEmployees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AppointmentId = table.Column<int>(type: "integer", nullable: false),
                    EmployeeId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_appointmentEmployees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_appointmentEmployees_AspNetUsers_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_appointmentEmployees_appointments_AppointmentId",
                        column: x => x.AppointmentId,
                        principalTable: "appointments",
                        principalColumn: "AppNo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeManager",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ManagerId = table.Column<string>(type: "text", nullable: false),
                    EmployeeID = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeManager", x => x.id);
                    table.ForeignKey(
                        name: "FK_EmployeeManager_AspNetUsers_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeManager_AspNetUsers_ManagerId",
                        column: x => x.ManagerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3807914b-1aa4-4882-b533-254b6cd7d696", null, "Customer", "CUSTOMER" },
                    { "5ed7f15f-2526-4e69-ae01-7d33b6c8b28c", null, "Manager", "MANAGER" },
                    { "b14e6f82-dda7-4397-b393-bb41c369987c", null, "Admin", "ADMIN" },
                    { "eead68f7-6ce8-40b5-a6d9-0e0ac3241222", null, "Employee", "EMPLOYEE" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c921a371-a2b8-4ef5-8015-339af1e76131", 0, "e85e73b9-cee5-40e1-b113-62ae2127e6b2", "User", "b221210566@ogr.sakarya.edu.tr", true, "Sara", "Mohamed", false, null, "b221210566@ogr.sakarya.edu.tr", "SaraMohamed", "AQAAAAIAAYagAAAAENeLlZ+IjPQjADwUtHowjgahBh2HFfYMvI+/l4AQJ8EJSoBmcKixrTI2JWfgbR4JMw==", null, false, "b861efe7-3b67-4a32-847e-82c1517570dc", false, "Sara Mohamed" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b14e6f82-dda7-4397-b393-bb41c369987c", "c921a371-a2b8-4ef5-8015-339af1e76131" });

            migrationBuilder.CreateIndex(
                name: "IX_appointments_UserId",
                table: "appointments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_appointmentEmployees_AppointmentId",
                table: "appointmentEmployees",
                column: "AppointmentId");

            migrationBuilder.CreateIndex(
                name: "IX_appointmentEmployees_EmployeeId",
                table: "appointmentEmployees",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeManager_EmployeeID",
                table: "EmployeeManager",
                column: "EmployeeID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeManager_ManagerId",
                table: "EmployeeManager",
                column: "ManagerId");

            migrationBuilder.AddForeignKey(
                name: "FK_appointments_AspNetUsers_UserId",
                table: "appointments",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_appointments_AspNetUsers_UserId",
                table: "appointments");

            migrationBuilder.DropTable(
                name: "appointmentEmployees");

            migrationBuilder.DropTable(
                name: "EmployeeManager");

            migrationBuilder.DropIndex(
                name: "IX_appointments_UserId",
                table: "appointments");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3807914b-1aa4-4882-b533-254b6cd7d696");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5ed7f15f-2526-4e69-ae01-7d33b6c8b28c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eead68f7-6ce8-40b5-a6d9-0e0ac3241222");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b14e6f82-dda7-4397-b393-bb41c369987c", "c921a371-a2b8-4ef5-8015-339af1e76131" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b14e6f82-dda7-4397-b393-bb41c369987c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c921a371-a2b8-4ef5-8015-339af1e76131");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "appointments");

            migrationBuilder.AddColumn<string>(
                name: "ManagerId",
                table: "AspNetUsers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ManagerId1",
                table: "AspNetUsers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmployeeId",
                table: "appointments",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EmployeeId1",
                table: "appointments",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "205ef2fe-b916-4975-8091-926f4c7a5bba", null, "Admin", "ADMIN" },
                    { "3a28b3a5-0f1c-4be4-b298-4bea3acab5c9", null, "Employee", "EMPLOYEE" },
                    { "71218633-20bc-4c82-a1b5-cdc5c8688a04", null, "Manager", "MANAGER" },
                    { "77114515-3f20-4517-8ee9-f5be9108095e", null, "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "5b5733fc-a5e3-4ceb-8edf-49f43ef22307", 0, "61c582c6-070f-4c69-9963-ea8af76bf105", "User", "b221210566@ogr.sakarya.edu.tr", true, "Sara", "Mohamed", false, null, "b221210566@ogr.sakarya.edu.tr", "SaraMohamed", "AQAAAAIAAYagAAAAEHozk0MSNeJpb3mI/6tN7U3A+i8EIAm246o59gkvUUqMdA/ECtY4elrc/vmlCFLSNw==", null, false, "1fda8839-2294-4fae-9b29-1bbf03658e80", false, "Sara Mohamed" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "205ef2fe-b916-4975-8091-926f4c7a5bba", "5b5733fc-a5e3-4ceb-8edf-49f43ef22307" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ManagerId",
                table: "AspNetUsers",
                column: "ManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ManagerId1",
                table: "AspNetUsers",
                column: "ManagerId1");

            migrationBuilder.CreateIndex(
                name: "IX_appointments_EmployeeId",
                table: "appointments",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_appointments_EmployeeId1",
                table: "appointments",
                column: "EmployeeId1");

            migrationBuilder.AddForeignKey(
                name: "FK_appointments_AspNetUsers_EmployeeId",
                table: "appointments",
                column: "EmployeeId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_appointments_AspNetUsers_EmployeeId1",
                table: "appointments",
                column: "EmployeeId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_AspNetUsers_ManagerId",
                table: "AspNetUsers",
                column: "ManagerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_AspNetUsers_ManagerId1",
                table: "AspNetUsers",
                column: "ManagerId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
