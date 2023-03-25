using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InventoryDesktop.EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class AddedPUrchase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Purchases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PurchaseItemId = table.Column<int>(type: "int", nullable: false),
                    PurchaseItemDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Batch = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Barcode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PerPacketQuantity = table.Column<int>(type: "int", nullable: false),
                    PurchasePacketQuantity = table.Column<int>(type: "int", nullable: false),
                    PurchasePacketPrice = table.Column<double>(type: "float", nullable: false),
                    PurchaseQuantity = table.Column<int>(type: "int", nullable: false),
                    PurchaseUnitPrice = table.Column<double>(type: "float", nullable: false),
                    SalePacketPrice = table.Column<double>(type: "float", nullable: false),
                    SaleUnitPrice = table.Column<double>(type: "float", nullable: false),
                    Expiry = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Purchases", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Purchases");
        }
    }
}
