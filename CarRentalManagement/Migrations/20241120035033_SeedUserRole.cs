using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "0df0aa75-60f6-4620-aa76-dbced1076d71", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEM0lNeaGFnheWCJ73HQNs7VpnsIERKutUd2IBd1HDHnYsbLZi9IpFYXxzeDMUcJNog==", null, false, "0904ada1-e791-43d7-a4f5-6fc122568c85", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 50, 32, 149, DateTimeKind.Local).AddTicks(2455), new DateTime(2024, 11, 20, 11, 50, 32, 149, DateTimeKind.Local).AddTicks(2471) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 50, 32, 149, DateTimeKind.Local).AddTicks(2475), new DateTime(2024, 11, 20, 11, 50, 32, 149, DateTimeKind.Local).AddTicks(2476) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 50, 32, 149, DateTimeKind.Local).AddTicks(2877), new DateTime(2024, 11, 20, 11, 50, 32, 149, DateTimeKind.Local).AddTicks(2879) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 50, 32, 149, DateTimeKind.Local).AddTicks(2883), new DateTime(2024, 11, 20, 11, 50, 32, 149, DateTimeKind.Local).AddTicks(2884) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 50, 32, 149, DateTimeKind.Local).AddTicks(3082), new DateTime(2024, 11, 20, 11, 50, 32, 149, DateTimeKind.Local).AddTicks(3083) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 50, 32, 149, DateTimeKind.Local).AddTicks(3087), new DateTime(2024, 11, 20, 11, 50, 32, 149, DateTimeKind.Local).AddTicks(3088) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 50, 32, 149, DateTimeKind.Local).AddTicks(3091), new DateTime(2024, 11, 20, 11, 50, 32, 149, DateTimeKind.Local).AddTicks(3092) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 50, 32, 149, DateTimeKind.Local).AddTicks(3095), new DateTime(2024, 11, 20, 11, 50, 32, 149, DateTimeKind.Local).AddTicks(3096) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 23, 26, 61, DateTimeKind.Local).AddTicks(5378), new DateTime(2024, 11, 20, 11, 23, 26, 61, DateTimeKind.Local).AddTicks(5395) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 23, 26, 61, DateTimeKind.Local).AddTicks(5399), new DateTime(2024, 11, 20, 11, 23, 26, 61, DateTimeKind.Local).AddTicks(5400) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 23, 26, 61, DateTimeKind.Local).AddTicks(5789), new DateTime(2024, 11, 20, 11, 23, 26, 61, DateTimeKind.Local).AddTicks(5791) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 23, 26, 61, DateTimeKind.Local).AddTicks(5795), new DateTime(2024, 11, 20, 11, 23, 26, 61, DateTimeKind.Local).AddTicks(5796) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 23, 26, 61, DateTimeKind.Local).AddTicks(6007), new DateTime(2024, 11, 20, 11, 23, 26, 61, DateTimeKind.Local).AddTicks(6009) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 23, 26, 61, DateTimeKind.Local).AddTicks(6012), new DateTime(2024, 11, 20, 11, 23, 26, 61, DateTimeKind.Local).AddTicks(6013) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 23, 26, 61, DateTimeKind.Local).AddTicks(6016), new DateTime(2024, 11, 20, 11, 23, 26, 61, DateTimeKind.Local).AddTicks(6017) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 23, 26, 61, DateTimeKind.Local).AddTicks(6020), new DateTime(2024, 11, 20, 11, 23, 26, 61, DateTimeKind.Local).AddTicks(6021) });
        }
    }
}
