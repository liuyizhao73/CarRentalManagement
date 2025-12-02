using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

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

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 14, 23, 25, 497, DateTimeKind.Local).AddTicks(3230), new DateTime(2025, 11, 27, 14, 23, 25, 497, DateTimeKind.Local).AddTicks(3251) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 14, 23, 25, 497, DateTimeKind.Local).AddTicks(3256), new DateTime(2025, 11, 27, 14, 23, 25, 497, DateTimeKind.Local).AddTicks(3257) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 14, 23, 25, 497, DateTimeKind.Local).AddTicks(3886), new DateTime(2025, 11, 27, 14, 23, 25, 497, DateTimeKind.Local).AddTicks(3887) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 14, 23, 25, 497, DateTimeKind.Local).AddTicks(3890), new DateTime(2025, 11, 27, 14, 23, 25, 497, DateTimeKind.Local).AddTicks(3891) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 14, 23, 25, 497, DateTimeKind.Local).AddTicks(3675), new DateTime(2025, 11, 27, 14, 23, 25, 497, DateTimeKind.Local).AddTicks(3676) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 14, 23, 25, 497, DateTimeKind.Local).AddTicks(3679), new DateTime(2025, 11, 27, 14, 23, 25, 497, DateTimeKind.Local).AddTicks(3680) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 14, 23, 25, 497, DateTimeKind.Local).AddTicks(3683), new DateTime(2025, 11, 27, 14, 23, 25, 497, DateTimeKind.Local).AddTicks(3684) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 14, 23, 25, 497, DateTimeKind.Local).AddTicks(3686), new DateTime(2025, 11, 27, 14, 23, 25, 497, DateTimeKind.Local).AddTicks(3687) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                values: new object[] { new DateTime(2025, 11, 27, 13, 29, 29, 462, DateTimeKind.Local).AddTicks(6984), new DateTime(2025, 11, 27, 13, 29, 29, 462, DateTimeKind.Local).AddTicks(7006) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 13, 29, 29, 462, DateTimeKind.Local).AddTicks(7012), new DateTime(2025, 11, 27, 13, 29, 29, 462, DateTimeKind.Local).AddTicks(7013) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 13, 29, 29, 462, DateTimeKind.Local).AddTicks(8163), new DateTime(2025, 11, 27, 13, 29, 29, 462, DateTimeKind.Local).AddTicks(8164) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 13, 29, 29, 462, DateTimeKind.Local).AddTicks(8167), new DateTime(2025, 11, 27, 13, 29, 29, 462, DateTimeKind.Local).AddTicks(8167) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 13, 29, 29, 462, DateTimeKind.Local).AddTicks(7734), new DateTime(2025, 11, 27, 13, 29, 29, 462, DateTimeKind.Local).AddTicks(7741) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 13, 29, 29, 462, DateTimeKind.Local).AddTicks(7748), new DateTime(2025, 11, 27, 13, 29, 29, 462, DateTimeKind.Local).AddTicks(7749) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 13, 29, 29, 462, DateTimeKind.Local).AddTicks(7751), new DateTime(2025, 11, 27, 13, 29, 29, 462, DateTimeKind.Local).AddTicks(7752) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 13, 29, 29, 462, DateTimeKind.Local).AddTicks(7755), new DateTime(2025, 11, 27, 13, 29, 29, 462, DateTimeKind.Local).AddTicks(7756) });
        }
    }
}
