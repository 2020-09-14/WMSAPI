using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WMS.Migrations
{
    public partial class addpurchase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Goods",
                columns: table => new
                {
                    GoodsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Conding = table.Column<int>(maxLength: 200, nullable: false),
                    InventorySettings = table.Column<int>(nullable: false),
                    Gname = table.Column<string>(maxLength: 200, nullable: true),
                    level = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Goods", x => x.GoodsId);
                });

            migrationBuilder.CreateTable(
                name: "Purchases",
                columns: table => new
                {
                    PurchaseId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PurchaseNum = table.Column<string>(maxLength: 200, nullable: false),
                    PurchaseSupplierId = table.Column<int>(nullable: false),
                    PurchaseTime = table.Column<DateTime>(nullable: false),
                    PurchaseName = table.Column<string>(maxLength: 200, nullable: false),
                    PurchaseGoodsId = table.Column<int>(nullable: false),
                    PurchaseState = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Purchases", x => x.PurchaseId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Goods");

            migrationBuilder.DropTable(
                name: "Purchases");
        }
    }
}
