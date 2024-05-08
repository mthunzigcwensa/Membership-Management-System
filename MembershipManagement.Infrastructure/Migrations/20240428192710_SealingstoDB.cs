using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MembershipManagement.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SealingstoDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sealings",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SealingId = table.Column<int>(type: "int", nullable: false),
                    SealingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AppliedByDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SealingType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sealings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sealings_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sealings_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "BranchID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sealings_BranchId",
                table: "Sealings",
                column: "BranchId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sealings");
        }
    }
}
