using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MembershipManagement.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class strategy : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sealings_AspNetUsers_Id",
                table: "Sealings");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUser",
                table: "Sealings",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Sealings",
                keyColumn: "Id",
                keyValue: "07f809e0-322f-4fcc-8570-1fc669f57ee7",
                columns: new[] { "ApplicationUser", "AppliedByDate" },
                values: new object[] { null, new DateTime(2024, 4, 29, 1, 32, 52, 384, DateTimeKind.Local).AddTicks(7814) });

            migrationBuilder.UpdateData(
                table: "Sealings",
                keyColumn: "Id",
                keyValue: "50eeab50-dc3a-4cdf-89d6-251efcdd50f3",
                columns: new[] { "ApplicationUser", "AppliedByDate" },
                values: new object[] { null, new DateTime(2024, 4, 29, 1, 32, 52, 384, DateTimeKind.Local).AddTicks(7811) });

            migrationBuilder.UpdateData(
                table: "Sealings",
                keyColumn: "Id",
                keyValue: "a3d8ae1e-1e15-4ae7-b6cd-cd37cca74269",
                columns: new[] { "ApplicationUser", "AppliedByDate" },
                values: new object[] { null, new DateTime(2024, 4, 29, 1, 32, 52, 384, DateTimeKind.Local).AddTicks(7789) });

            migrationBuilder.UpdateData(
                table: "Sealings",
                keyColumn: "Id",
                keyValue: "c994283e-7d07-4c8a-a11f-b7c4c616d4f9",
                columns: new[] { "ApplicationUser", "AppliedByDate" },
                values: new object[] { null, new DateTime(2024, 4, 29, 1, 32, 52, 384, DateTimeKind.Local).AddTicks(7807) });

            migrationBuilder.CreateIndex(
                name: "IX_Sealings_ApplicationUser",
                table: "Sealings",
                column: "ApplicationUser");

            migrationBuilder.AddForeignKey(
                name: "FK_Sealings_AspNetUsers_ApplicationUser",
                table: "Sealings",
                column: "ApplicationUser",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sealings_AspNetUsers_ApplicationUser",
                table: "Sealings");

            migrationBuilder.DropIndex(
                name: "IX_Sealings_ApplicationUser",
                table: "Sealings");

            migrationBuilder.DropColumn(
                name: "ApplicationUser",
                table: "Sealings");

            migrationBuilder.UpdateData(
                table: "Sealings",
                keyColumn: "Id",
                keyValue: "07f809e0-322f-4fcc-8570-1fc669f57ee7",
                column: "AppliedByDate",
                value: new DateTime(2024, 4, 28, 22, 30, 50, 37, DateTimeKind.Local).AddTicks(252));

            migrationBuilder.UpdateData(
                table: "Sealings",
                keyColumn: "Id",
                keyValue: "50eeab50-dc3a-4cdf-89d6-251efcdd50f3",
                column: "AppliedByDate",
                value: new DateTime(2024, 4, 28, 22, 30, 50, 37, DateTimeKind.Local).AddTicks(248));

            migrationBuilder.UpdateData(
                table: "Sealings",
                keyColumn: "Id",
                keyValue: "a3d8ae1e-1e15-4ae7-b6cd-cd37cca74269",
                column: "AppliedByDate",
                value: new DateTime(2024, 4, 28, 22, 30, 50, 37, DateTimeKind.Local).AddTicks(196));

            migrationBuilder.UpdateData(
                table: "Sealings",
                keyColumn: "Id",
                keyValue: "c994283e-7d07-4c8a-a11f-b7c4c616d4f9",
                column: "AppliedByDate",
                value: new DateTime(2024, 4, 28, 22, 30, 50, 37, DateTimeKind.Local).AddTicks(213));

            migrationBuilder.AddForeignKey(
                name: "FK_Sealings_AspNetUsers_Id",
                table: "Sealings",
                column: "Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
