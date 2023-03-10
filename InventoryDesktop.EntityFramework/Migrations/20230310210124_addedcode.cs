using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InventoryDesktop.EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class addedcode : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "ItemTypes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "ItemCategories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Code",
                table: "ItemTypes");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "ItemCategories");
        }
    }
}
