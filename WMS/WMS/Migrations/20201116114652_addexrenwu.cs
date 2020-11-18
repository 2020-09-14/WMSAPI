using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WMS.Migrations
{
    public partial class addexrenwu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "EX_Shipment");

            migrationBuilder.AddColumn<string>(
                name: "Cause",
                table: "EX_Shipment",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Shsum",
                table: "EX_Shipment",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SupplierIdd",
                table: "EX_Shipment",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "article",
                table: "EX_Shipment",
                maxLength: 200,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "EX_Renwus",
                columns: table => new
                {
                    ShipmentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShCoding = table.Column<string>(maxLength: 200, nullable: true),
                    Createtime = table.Column<DateTime>(nullable: false),
                    State = table.Column<int>(nullable: false),
                    Goodsidd = table.Column<int>(nullable: false),
                    Cause = table.Column<string>(maxLength: 200, nullable: true),
                    article = table.Column<string>(maxLength: 200, nullable: true),
                    Shsum = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EX_Renwus", x => x.ShipmentId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EX_Renwus");

            migrationBuilder.DropColumn(
                name: "Cause",
                table: "EX_Shipment");

            migrationBuilder.DropColumn(
                name: "Shsum",
                table: "EX_Shipment");

            migrationBuilder.DropColumn(
                name: "SupplierIdd",
                table: "EX_Shipment");

            migrationBuilder.DropColumn(
                name: "article",
                table: "EX_Shipment");

            migrationBuilder.AddColumn<int>(
                name: "MyProperty",
                table: "EX_Shipment",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
