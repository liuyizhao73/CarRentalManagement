using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRoleFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "51d12c90-b27a-41c4-b42e-9967b8b69c01", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEECDPtrDZP6L4bld780orYme29Zk55rVtpqGdjLmGoAfyegyvRRd+0ryqF3O/P3YaQ==", null, false, "2b785933-394a-4497-814a-0dda6ffa3e56", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 14, 37, 54, 284, DateTimeKind.Local).AddTicks(667), new DateTime(2025, 11, 27, 14, 37, 54, 284, DateTimeKind.Local).AddTicks(737) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 14, 37, 54, 284, DateTimeKind.Local).AddTicks(750), new DateTime(2025, 11, 27, 14, 37, 54, 284, DateTimeKind.Local).AddTicks(751) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 14, 37, 54, 284, DateTimeKind.Local).AddTicks(1436), new DateTime(2025, 11, 27, 14, 37, 54, 284, DateTimeKind.Local).AddTicks(1437) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 14, 37, 54, 284, DateTimeKind.Local).AddTicks(1439), new DateTime(2025, 11, 27, 14, 37, 54, 284, DateTimeKind.Local).AddTicks(1440) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 14, 37, 54, 284, DateTimeKind.Local).AddTicks(1210), new DateTime(2025, 11, 27, 14, 37, 54, 284, DateTimeKind.Local).AddTicks(1211) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 14, 37, 54, 284, DateTimeKind.Local).AddTicks(1214), new DateTime(2025, 11, 27, 14, 37, 54, 284, DateTimeKind.Local).AddTicks(1215) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 14, 37, 54, 284, DateTimeKind.Local).AddTicks(1218), new DateTime(2025, 11, 27, 14, 37, 54, 284, DateTimeKind.Local).AddTicks(1219) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 14, 37, 54, 284, DateTimeKind.Local).AddTicks(1221), new DateTime(2025, 11, 27, 14, 37, 54, 284, DateTimeKind.Local).AddTicks(1222) });

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
    }
}
