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
                    { 1, "System", new DateTime(2025, 11, 25, 11, 48, 23, 779, DateTimeKind.Local).AddTicks(6268), new DateTime(2025, 11, 25, 11, 48, 23, 779, DateTimeKind.Local).AddTicks(6290), "Black", "System" },
                    { 2, "System", new DateTime(2025, 11, 25, 11, 48, 23, 779, DateTimeKind.Local).AddTicks(6296), new DateTime(2025, 11, 25, 11, 48, 23, 779, DateTimeKind.Local).AddTicks(6298), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 25, 11, 48, 23, 779, DateTimeKind.Local).AddTicks(7412), new DateTime(2025, 11, 25, 11, 48, 23, 779, DateTimeKind.Local).AddTicks(7416), "BMW", "System" },
                    { 2, "System", new DateTime(2025, 11, 25, 11, 48, 23, 779, DateTimeKind.Local).AddTicks(7419), new DateTime(2025, 11, 25, 11, 48, 23, 779, DateTimeKind.Local).AddTicks(7421), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 25, 11, 48, 23, 779, DateTimeKind.Local).AddTicks(6893), new DateTime(2025, 11, 25, 11, 48, 23, 779, DateTimeKind.Local).AddTicks(6897), "i4", "System" },
                    { 2, "System", new DateTime(2025, 11, 25, 11, 48, 23, 779, DateTimeKind.Local).AddTicks(6901), new DateTime(2025, 11, 25, 11, 48, 23, 779, DateTimeKind.Local).AddTicks(6902), "x5", "System" },
                    { 3, "System", new DateTime(2025, 11, 25, 11, 48, 23, 779, DateTimeKind.Local).AddTicks(6906), new DateTime(2025, 11, 25, 11, 48, 23, 779, DateTimeKind.Local).AddTicks(6907), "Prius", "System" },
                    { 4, "System", new DateTime(2025, 11, 25, 11, 48, 23, 779, DateTimeKind.Local).AddTicks(6910), new DateTime(2025, 11, 25, 11, 48, 23, 779, DateTimeKind.Local).AddTicks(6911), "C-HR", "System" }
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
