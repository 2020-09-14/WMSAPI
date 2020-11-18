using Microsoft.EntityFrameworkCore.Migrations;

namespace WMS.Migrations
{
    public partial class addchukuu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EX_GoodsOutbounds",
                columns: table => new
                {
                    GoodsOId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GoCoding = table.Column<string>(maxLength: 200, nullable: false),
                    Gosum = table.Column<int>(nullable: false),
                    GoName = table.Column<string>(nullable: true),
                    GoSpecification = table.Column<string>(maxLength: 200, nullable: false),
                    RenIdd = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EX_GoodsOutbounds", x => x.GoodsOId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EX_GoodsOutbounds");
        }
    }
}
