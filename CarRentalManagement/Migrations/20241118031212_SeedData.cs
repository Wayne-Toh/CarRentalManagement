using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 11, 12, 11, 572, DateTimeKind.Local).AddTicks(518), new DateTime(2024, 11, 18, 11, 12, 11, 572, DateTimeKind.Local).AddTicks(530), "Black", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 11, 12, 11, 572, DateTimeKind.Local).AddTicks(536), new DateTime(2024, 11, 18, 11, 12, 11, 572, DateTimeKind.Local).AddTicks(537), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 11, 12, 11, 572, DateTimeKind.Local).AddTicks(701), new DateTime(2024, 11, 18, 11, 12, 11, 572, DateTimeKind.Local).AddTicks(702), "BMW", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 11, 12, 11, 572, DateTimeKind.Local).AddTicks(704), new DateTime(2024, 11, 18, 11, 12, 11, 572, DateTimeKind.Local).AddTicks(705), "Toyata", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 11, 12, 11, 572, DateTimeKind.Local).AddTicks(782), new DateTime(2024, 11, 18, 11, 12, 11, 572, DateTimeKind.Local).AddTicks(783), "i4", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 11, 12, 11, 572, DateTimeKind.Local).AddTicks(784), new DateTime(2024, 11, 18, 11, 12, 11, 572, DateTimeKind.Local).AddTicks(784), "X5", "System" },
                    { 3, "System", new DateTime(2024, 11, 18, 11, 12, 11, 572, DateTimeKind.Local).AddTicks(785), new DateTime(2024, 11, 18, 11, 12, 11, 572, DateTimeKind.Local).AddTicks(786), "Prius", "System" },
                    { 4, "System", new DateTime(2024, 11, 18, 11, 12, 11, 572, DateTimeKind.Local).AddTicks(787), new DateTime(2024, 11, 18, 11, 12, 11, 572, DateTimeKind.Local).AddTicks(788), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
