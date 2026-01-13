using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proj_bazy.Migrations
{
    /// <inheritdoc />
    public partial class AdminAdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Price",
                table: "RoomTypes",
                newName: "PricePerNight");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PricePerNight",
                table: "RoomTypes",
                newName: "Price");
        }
    }
}
