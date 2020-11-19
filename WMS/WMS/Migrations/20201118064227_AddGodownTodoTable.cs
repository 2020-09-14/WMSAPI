using Microsoft.EntityFrameworkCore.Migrations;

namespace WMS.Migrations
{
    public partial class AddGodownTodoTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GodownTodos",
                columns: table => new
                {
                    GodownTodoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GodownTodoNum = table.Column<string>(nullable: true),
                    GodownTodoPurchaseId = table.Column<int>(nullable: false),
                    GodownTodoState = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GodownTodos", x => x.GodownTodoId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GodownTodos");
        }
    }
}
