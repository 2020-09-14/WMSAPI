using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WMS.Migrations
{
    public partial class addnewtable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DailyStatement",
                columns: table => new
                {
                    DailyStatementId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pname = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DailyStatement", x => x.DailyStatementId);
                });

            migrationBuilder.CreateTable(
                name: "Ex_GoodsOne",
                columns: table => new
                {
                    Ex_GoodsOneId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GOname = table.Column<string>(maxLength: 200, nullable: false),
                    Coding = table.Column<string>(maxLength: 200, nullable: false),
                    ONEsum = table.Column<int>(nullable: false),
                    Pidd = table.Column<int>(nullable: false),
                    Supplier = table.Column<int>(maxLength: 200, nullable: false),
                    State = table.Column<int>(nullable: false),
                    Createtime = table.Column<DateTime>(nullable: false),
                    PurchasePerson = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ex_GoodsOne", x => x.Ex_GoodsOneId);
                });

            migrationBuilder.CreateTable(
                name: "Ex_GoodsThr",
                columns: table => new
                {
                    GoodsThId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GTname = table.Column<int>(maxLength: 200, nullable: false),
                    Specification = table.Column<int>(maxLength: 200, nullable: false),
                    Coding = table.Column<string>(maxLength: 200, nullable: true),
                    State = table.Column<int>(nullable: false),
                    TWOIdd = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ex_GoodsThr", x => x.GoodsThId);
                });

            migrationBuilder.CreateTable(
                name: "Ex_GoodsTWO",
                columns: table => new
                {
                    Ex_GoodsTWOId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GWname = table.Column<string>(maxLength: 200, nullable: false),
                    Specification = table.Column<string>(maxLength: 200, nullable: false),
                    OneIdd = table.Column<int>(nullable: false),
                    Coding = table.Column<string>(maxLength: 200, nullable: false),
                    TWOsum = table.Column<int>(nullable: false),
                    EX_ZhyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ex_GoodsTWO", x => x.Ex_GoodsTWOId);
                });

            migrationBuilder.CreateTable(
                name: "EX_ProductCategory",
                columns: table => new
                {
                    ProductCategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pidd = table.Column<int>(nullable: false),
                    ProductName = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EX_ProductCategory", x => x.ProductCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "EX_ReservoirArea",
                columns: table => new
                {
                    ReservoirAreaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rname = table.Column<string>(maxLength: 200, nullable: true),
                    Remark = table.Column<string>(maxLength: 200, nullable: true),
                    TemperatureZone = table.Column<string>(maxLength: 200, nullable: true),
                    WIdd = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EX_ReservoirArea", x => x.ReservoirAreaId);
                });

            migrationBuilder.CreateTable(
                name: "EX_supplier",
                columns: table => new
                {
                    SupplierId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplierName = table.Column<string>(maxLength: 200, nullable: true),
                    Serial = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EX_supplier", x => x.SupplierId);
                });

            migrationBuilder.CreateTable(
                name: "EX_Warehouse",
                columns: table => new
                {
                    WarehouseId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Wname = table.Column<string>(maxLength: 200, nullable: false),
                    Address = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EX_Warehouse", x => x.WarehouseId);
                });

            migrationBuilder.CreateTable(
                name: "EX_Zhy",
                columns: table => new
                {
                    ZhyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Zname = table.Column<string>(maxLength: 200, nullable: true),
                    TemperatureZone = table.Column<string>(maxLength: 200, nullable: true),
                    Ridd = table.Column<int>(nullable: false),
                    InventorySettings = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EX_Zhy", x => x.ZhyId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DailyStatement");

            migrationBuilder.DropTable(
                name: "Ex_GoodsOne");

            migrationBuilder.DropTable(
                name: "Ex_GoodsThr");

            migrationBuilder.DropTable(
                name: "Ex_GoodsTWO");

            migrationBuilder.DropTable(
                name: "EX_ProductCategory");

            migrationBuilder.DropTable(
                name: "EX_ReservoirArea");

            migrationBuilder.DropTable(
                name: "EX_supplier");

            migrationBuilder.DropTable(
                name: "EX_Warehouse");

            migrationBuilder.DropTable(
                name: "EX_Zhy");
        }
    }
}
