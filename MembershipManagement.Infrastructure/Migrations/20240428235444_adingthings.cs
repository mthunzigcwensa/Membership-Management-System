using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MembershipManagement.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class adingthings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Sealings",
                keyColumn: "Id",
                keyValue: "07f809e0-322f-4fcc-8570-1fc669f57ee7",
                column: "AppliedByDate",
                value: new DateTime(2024, 4, 29, 1, 54, 44, 537, DateTimeKind.Local).AddTicks(2862));

            migrationBuilder.UpdateData(
                table: "Sealings",
                keyColumn: "Id",
                keyValue: "50eeab50-dc3a-4cdf-89d6-251efcdd50f3",
                column: "AppliedByDate",
                value: new DateTime(2024, 4, 29, 1, 54, 44, 537, DateTimeKind.Local).AddTicks(2858));

            migrationBuilder.UpdateData(
                table: "Sealings",
                keyColumn: "Id",
                keyValue: "a3d8ae1e-1e15-4ae7-b6cd-cd37cca74269",
                column: "AppliedByDate",
                value: new DateTime(2024, 4, 29, 1, 54, 44, 537, DateTimeKind.Local).AddTicks(2837));

            migrationBuilder.UpdateData(
                table: "Sealings",
                keyColumn: "Id",
                keyValue: "c994283e-7d07-4c8a-a11f-b7c4c616d4f9",
                column: "AppliedByDate",
                value: new DateTime(2024, 4, 29, 1, 54, 44, 537, DateTimeKind.Local).AddTicks(2854));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Sealings",
                keyColumn: "Id",
                keyValue: "07f809e0-322f-4fcc-8570-1fc669f57ee7",
                column: "AppliedByDate",
                value: new DateTime(2024, 4, 29, 1, 32, 52, 384, DateTimeKind.Local).AddTicks(7814));

            migrationBuilder.UpdateData(
                table: "Sealings",
                keyColumn: "Id",
                keyValue: "50eeab50-dc3a-4cdf-89d6-251efcdd50f3",
                column: "AppliedByDate",
                value: new DateTime(2024, 4, 29, 1, 32, 52, 384, DateTimeKind.Local).AddTicks(7811));

            migrationBuilder.UpdateData(
                table: "Sealings",
                keyColumn: "Id",
                keyValue: "a3d8ae1e-1e15-4ae7-b6cd-cd37cca74269",
                column: "AppliedByDate",
                value: new DateTime(2024, 4, 29, 1, 32, 52, 384, DateTimeKind.Local).AddTicks(7789));

            migrationBuilder.UpdateData(
                table: "Sealings",
                keyColumn: "Id",
                keyValue: "c994283e-7d07-4c8a-a11f-b7c4c616d4f9",
                column: "AppliedByDate",
                value: new DateTime(2024, 4, 29, 1, 32, 52, 384, DateTimeKind.Local).AddTicks(7807));
        }
    }
}
