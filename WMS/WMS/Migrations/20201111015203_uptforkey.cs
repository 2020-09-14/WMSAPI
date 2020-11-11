using Microsoft.EntityFrameworkCore.Migrations;

namespace WMS.Migrations
{
    public partial class uptforkey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "eX_SupplierSupplierId",
                table: "Purchases",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Purchases_eX_SupplierSupplierId",
                table: "Purchases",
                column: "eX_SupplierSupplierId");

            migrationBuilder.AddForeignKey(
                name: "FK_Purchases_EX_supplier_eX_SupplierSupplierId",
                table: "Purchases",
                column: "eX_SupplierSupplierId",
                principalTable: "EX_supplier",
                principalColumn: "SupplierId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Purchases_EX_supplier_eX_SupplierSupplierId",
                table: "Purchases");

            migrationBuilder.DropIndex(
                name: "IX_Purchases_eX_SupplierSupplierId",
                table: "Purchases");

            migrationBuilder.DropColumn(
                name: "eX_SupplierSupplierId",
                table: "Purchases");
        }
    }
}
