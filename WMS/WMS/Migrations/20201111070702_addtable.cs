using Microsoft.EntityFrameworkCore.Migrations;

namespace WMS.Migrations
{
    public partial class addtable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AOGQualityTests",
                columns: table => new
                {
                    AOGTestId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AOGRegister = table.Column<int>(nullable: false),
                    AOGTestOknum = table.Column<int>(nullable: false),
                    AOGTestNonum = table.Column<int>(nullable: false),
                    AOGTestName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AOGQualityTests", x => x.AOGTestId);
                });

            migrationBuilder.CreateTable(
                name: "AOGregisters",
                columns: table => new
                {
                    AOGId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AOGPurchase = table.Column<int>(nullable: false),
                    AOGState = table.Column<int>(nullable: false),
                    AOGNum = table.Column<int>(nullable: false),
                    AOGWarehouse = table.Column<int>(nullable: false),
                    AOGRemark = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AOGregisters", x => x.AOGId);
                });

            migrationBuilder.CreateTable(
                name: "Godowns",
                columns: table => new
                {
                    GodownId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GodownRegisterId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Godowns", x => x.GodownId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AOGQualityTests");

            migrationBuilder.DropTable(
                name: "AOGregisters");

            migrationBuilder.DropTable(
                name: "Godowns");
        }
    }
}
