using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WMS.Migrations
{
    public partial class addChecks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Checks",
                columns: table => new
                {
                    CheckTaskId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CheckName = table.Column<string>(nullable: true),
                    CheckCNo = table.Column<string>(nullable: true),
                    CheckTimes = table.Column<DateTime>(nullable: false),
                    WareHouseName = table.Column<string>(nullable: true),
                    kQName = table.Column<string>(nullable: true),
                    HjName = table.Column<string>(nullable: true),
                    DefaultInventoryPeople = table.Column<string>(nullable: true),
                    CheckDetail = table.Column<string>(nullable: true),
                    ProductId = table.Column<int>(nullable: false),
                    CheckStates = table.Column<int>(nullable: false),
                    CheckNumber = table.Column<int>(nullable: false),
                    TaskTimes = table.Column<DateTime>(nullable: false),
                    CheckNum = table.Column<int>(nullable: false),
                    BatchNumber = table.Column<string>(nullable: true),
                    TermOfValidity = table.Column<DateTime>(nullable: false),
                    GoodsAllocation = table.Column<string>(nullable: true),
                    GoodsIds = table.Column<int>(nullable: false),
                    GoodsTWOIds = table.Column<int>(nullable: false),
                    ProductCategoryIds = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Checks", x => x.CheckTaskId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Checks");
        }
    }
}
