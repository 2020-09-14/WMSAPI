using Microsoft.EntityFrameworkCore.Migrations;

namespace WMS.Migrations
{
    public partial class _777 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TemperatureZone",
                table: "EX_Zhy");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TemperatureZone",
                table: "EX_Zhy",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);
        }
    }
}
