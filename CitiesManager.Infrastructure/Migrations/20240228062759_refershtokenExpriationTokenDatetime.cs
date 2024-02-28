using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CitiesManager.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class refershtokenExpriationTokenDatetime : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "RefreshTokenExpriationDatetime",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RefreshTokenExpriationDatetime",
                table: "AspNetUsers");
        }
    }
}
