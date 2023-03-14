using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InventoryDesktop.EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class AddedIsIncluded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsIncluded",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsIncluded",
                table: "Users");
        }
    }
}
