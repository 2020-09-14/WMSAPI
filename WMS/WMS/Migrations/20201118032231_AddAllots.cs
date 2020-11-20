using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WMS.Migrations
{
    public partial class AddAllots : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Allots",
                columns: table => new
                {
                    AId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ARequisition = table.Column<string>(nullable: false),
                    ACallout = table.Column<string>(nullable: false),
                    AFold = table.Column<string>(nullable: false),
                    APerson = table.Column<string>(nullable: false),
                    ADate = table.Column<DateTime>(nullable: false),
                    AAuditstatus = table.Column<int>(nullable: false),
                    AAllocatingstate = table.Column<int>(nullable: false),
                    APackingquantity = table.Column<int>(nullable: false),
                    AWId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Allots", x => x.AId);
                });

            migrationBuilder.CreateTable(
                name: "BStorages",
                columns: table => new
                {
                    BId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BEntry = table.Column<string>(nullable: false),
                    BTS = table.Column<string>(nullable: false),
                    BWarehouse = table.Column<string>(nullable: false),
                    BFold = table.Column<string>(nullable: false),
                    BSend = table.Column<DateTime>(nullable: false),
                    BEnter = table.Column<DateTime>(nullable: false),
                    BWarm = table.Column<string>(nullable: false),
                    BSum = table.Column<int>(nullable: false),
                    BPerson = table.Column<string>(nullable: false),
                    BConsignee = table.Column<string>(nullable: false),
                    BWId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BStorages", x => x.BId);
                });

            migrationBuilder.CreateTable(
                name: "Detailss",
                columns: table => new
                {
                    DId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DRepairinvoice = table.Column<string>(nullable: false),
                    DDate = table.Column<DateTime>(nullable: false),
                    DClassify = table.Column<string>(nullable: false),
                    DName = table.Column<string>(nullable: false),
                    DCoding = table.Column<string>(nullable: false),
                    DSpecification = table.Column<string>(nullable: false),
                    DPrice = table.Column<decimal>(nullable: false),
                    DAmount = table.Column<int>(nullable: false),
                    DAvailable = table.Column<int>(nullable: false),
                    DTotal = table.Column<string>(nullable: false),
                    DAudit = table.Column<int>(nullable: false),
                    DTotalNum = table.Column<int>(nullable: false),
                    DComparison = table.Column<int>(nullable: false),
                    DClose = table.Column<int>(nullable: false),
                    DWId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Detailss", x => x.DId);
                });

            migrationBuilder.CreateTable(
                name: "EDisposes",
                columns: table => new
                {
                    EId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EEntry = table.Column<string>(nullable: false),
                    EWarehouse = table.Column<string>(nullable: false),
                    EEnter = table.Column<DateTime>(nullable: false),
                    EConsignee = table.Column<string>(nullable: false),
                    EWarm = table.Column<string>(nullable: false),
                    ECategory = table.Column<string>(nullable: false),
                    ECoding = table.Column<string>(nullable: false),
                    EName = table.Column<string>(nullable: false),
                    ESpectification = table.Column<string>(nullable: false),
                    EUnit = table.Column<string>(nullable: false),
                    EBatch = table.Column<string>(nullable: false),
                    EAllocation = table.Column<string>(nullable: false),
                    EQuantity = table.Column<int>(nullable: false),
                    EDisposer = table.Column<int>(nullable: false),
                    EWId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EDisposes", x => x.EId);
                });

            migrationBuilder.CreateTable(
                name: "Itemdetailss",
                columns: table => new
                {
                    IId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IItemcode = table.Column<string>(nullable: false),
                    IName = table.Column<string>(nullable: false),
                    IInventory = table.Column<int>(nullable: false),
                    IApply = table.Column<int>(nullable: false),
                    IExamine = table.Column<int>(nullable: false),
                    IHaveoutbound = table.Column<int>(nullable: false),
                    IUnits = table.Column<string>(nullable: false),
                    IPrice = table.Column<decimal>(nullable: false),
                    IPicture = table.Column<string>(nullable: false),
                    IWId = table.Column<int>(nullable: false),
                    ISum = table.Column<int>(nullable: false),
                    IMoney = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Itemdetailss", x => x.IId);
                });

            migrationBuilder.CreateTable(
                name: "Notarizes",
                columns: table => new
                {
                    NId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NCoding = table.Column<string>(nullable: false),
                    NOdd = table.Column<string>(nullable: false),
                    NOutlet = table.Column<string>(nullable: false),
                    NWarm = table.Column<string>(nullable: false),
                    NSCoding = table.Column<string>(nullable: false),
                    NName = table.Column<string>(nullable: false),
                    NSpecification = table.Column<string>(nullable: false),
                    NQuantity = table.Column<int>(nullable: false),
                    NPerson = table.Column<string>(nullable: false),
                    NDate = table.Column<DateTime>(nullable: false),
                    NState = table.Column<int>(nullable: false),
                    NWId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notarizes", x => x.NId);
                });

            migrationBuilder.CreateTable(
                name: "Prints",
                columns: table => new
                {
                    PId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PCoding = table.Column<string>(nullable: false),
                    PBatch = table.Column<string>(nullable: false),
                    PCategory = table.Column<int>(nullable: false),
                    PName = table.Column<string>(nullable: false),
                    PSpecification = table.Column<string>(nullable: false),
                    PUnit = table.Column<string>(nullable: false),
                    PQuantity = table.Column<int>(nullable: false),
                    PTime = table.Column<DateTime>(nullable: false),
                    PPerson = table.Column<string>(nullable: false),
                    PWId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prints", x => x.PId);
                });

            migrationBuilder.CreateTable(
                name: "SendTheShippings",
                columns: table => new
                {
                    SId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SNumber = table.Column<string>(nullable: false),
                    SWarm = table.Column<string>(nullable: false),
                    SAmount = table.Column<int>(nullable: false),
                    SRemind = table.Column<string>(nullable: false),
                    SWId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SendTheShippings", x => x.SId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Allots");

            migrationBuilder.DropTable(
                name: "BStorages");

            migrationBuilder.DropTable(
                name: "Detailss");

            migrationBuilder.DropTable(
                name: "EDisposes");

            migrationBuilder.DropTable(
                name: "Itemdetailss");

            migrationBuilder.DropTable(
                name: "Notarizes");

            migrationBuilder.DropTable(
                name: "Prints");

            migrationBuilder.DropTable(
                name: "SendTheShippings");
        }
    }
}
