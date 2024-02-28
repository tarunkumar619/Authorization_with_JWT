using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CitiesManager.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class CreateRefreshTokenField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Refresh",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Refresh",
                table: "AspNetUsers");
        }
    }
}
