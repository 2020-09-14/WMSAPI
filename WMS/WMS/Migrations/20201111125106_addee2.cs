using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WMS.Migrations
{
    public partial class addee2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EX_Shipment",
                columns: table => new
                {
                    ShipmentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShCoding = table.Column<string>(maxLength: 200, nullable: true),
                    Createtime = table.Column<DateTime>(nullable: false),
                    Goodsidd = table.Column<int>(nullable: false),
                    MyProperty = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EX_Shipment", x => x.ShipmentId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EX_Shipment");
        }
    }
}
