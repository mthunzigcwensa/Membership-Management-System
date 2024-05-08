using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MembershipManagement.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Sealings",
                columns: new[] { "Id", "AppliedByDate", "BranchId", "SealingDate", "SealingId", "SealingType", "Status" },
                values: new object[,]
                {
                    { "07f809e0-322f-4fcc-8570-1fc669f57ee7", new DateTime(2024, 4, 28, 22, 30, 50, 37, DateTimeKind.Local).AddTicks(252), 3, new DateTime(2024, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Regular", "Submitted" },
                    { "50eeab50-dc3a-4cdf-89d6-251efcdd50f3", new DateTime(2024, 4, 28, 22, 30, 50, 37, DateTimeKind.Local).AddTicks(248), 3, new DateTime(2024, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Regular", "Submitted" },
                    { "a3d8ae1e-1e15-4ae7-b6cd-cd37cca74269", new DateTime(2024, 4, 28, 22, 30, 50, 37, DateTimeKind.Local).AddTicks(196), 3, new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Regular", "Submitted" },
                    { "c994283e-7d07-4c8a-a11f-b7c4c616d4f9", new DateTime(2024, 4, 28, 22, 30, 50, 37, DateTimeKind.Local).AddTicks(213), 3, new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Regular", "Submitted" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Sealings",
                keyColumn: "Id",
                keyValue: "07f809e0-322f-4fcc-8570-1fc669f57ee7");

            migrationBuilder.DeleteData(
                table: "Sealings",
                keyColumn: "Id",
                keyValue: "50eeab50-dc3a-4cdf-89d6-251efcdd50f3");

            migrationBuilder.DeleteData(
                table: "Sealings",
                keyColumn: "Id",
                keyValue: "a3d8ae1e-1e15-4ae7-b6cd-cd37cca74269");

            migrationBuilder.DeleteData(
                table: "Sealings",
                keyColumn: "Id",
                keyValue: "c994283e-7d07-4c8a-a11f-b7c4c616d4f9");
        }
    }
}
