using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MembershipManagement.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SealingstoDBTHREE : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MemberId",
                table: "Sealings");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MemberId",
                table: "Sealings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
