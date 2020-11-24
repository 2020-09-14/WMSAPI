﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WMS.Database;

namespace WMS.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20201118032231_AddAllots")]
    partial class AddAllots
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WMS.Models.AOGQualityTest", b =>
                {
                    b.Property<int>("AOGTestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AOGRegister")
                        .HasColumnType("int");

                    b.Property<string>("AOGTestName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AOGTestNonum")
                        .HasColumnType("int");

                    b.Property<int>("AOGTestOknum")
                        .HasColumnType("int");

                    b.HasKey("AOGTestId");

                    b.ToTable("AOGQualityTests");
                });

            modelBuilder.Entity("WMS.Models.AOGregister", b =>
                {
                    b.Property<int>("AOGId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AOGNum")
                        .HasColumnType("int");

                    b.Property<int>("AOGPurchase")
                        .HasColumnType("int");

                    b.Property<string>("AOGRemark")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AOGState")
                        .HasColumnType("int");

                    b.Property<int>("AOGWarehouse")
                        .HasColumnType("int");

                    b.HasKey("AOGId");

                    b.ToTable("AOGregisters");
                });

            modelBuilder.Entity("WMS.Models.Allot", b =>
                {
                    b.Property<int>("AId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AAllocatingstate")
                        .HasColumnType("int");

                    b.Property<int>("AAuditstatus")
                        .HasColumnType("int");

                    b.Property<string>("ACallout")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ADate")
                        .HasColumnType("datetime2");

                    b.Property<string>("AFold")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("APackingquantity")
                        .HasColumnType("int");

                    b.Property<string>("APerson")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ARequisition")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AWId")
                        .HasColumnType("int");

                    b.HasKey("AId");

                    b.ToTable("Allots");
                });

            modelBuilder.Entity("WMS.Models.BStorage", b =>
                {
                    b.Property<int>("BId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BConsignee")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BEnter")
                        .HasColumnType("datetime2");

                    b.Property<string>("BEntry")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BFold")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BPerson")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BSend")
                        .HasColumnType("datetime2");

                    b.Property<int>("BSum")
                        .HasColumnType("int");

                    b.Property<string>("BTS")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BWId")
                        .HasColumnType("int");

                    b.Property<string>("BWarehouse")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BWarm")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BId");

                    b.ToTable("BStorages");
                });

            modelBuilder.Entity("WMS.Models.DailyStatement", b =>
                {
                    b.Property<int>("DailyStatementId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Pname")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("DailyStatementId");

                    b.ToTable("DailyStatement");
                });

            modelBuilder.Entity("WMS.Models.Details", b =>
                {
                    b.Property<int>("DId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DAmount")
                        .HasColumnType("int");

                    b.Property<int>("DAudit")
                        .HasColumnType("int");

                    b.Property<int>("DAvailable")
                        .HasColumnType("int");

                    b.Property<string>("DClassify")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DClose")
                        .HasColumnType("int");

                    b.Property<string>("DCoding")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DComparison")
                        .HasColumnType("int");

                    b.Property<DateTime>("DDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("DPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("DRepairinvoice")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DSpecification")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DTotal")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DTotalNum")
                        .HasColumnType("int");

                    b.Property<int>("DWId")
                        .HasColumnType("int");

                    b.HasKey("DId");

                    b.ToTable("Detailss");
                });

            modelBuilder.Entity("WMS.Models.EDispose", b =>
                {
                    b.Property<int>("EId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EAllocation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EBatch")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ECategory")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ECoding")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EConsignee")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EDisposer")
                        .HasColumnType("int");

                    b.Property<DateTime>("EEnter")
                        .HasColumnType("datetime2");

                    b.Property<string>("EEntry")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EQuantity")
                        .HasColumnType("int");

                    b.Property<string>("ESpectification")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EUnit")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EWId")
                        .HasColumnType("int");

                    b.Property<string>("EWarehouse")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EWarm")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EId");

                    b.ToTable("EDisposes");
                });

            modelBuilder.Entity("WMS.Models.EX_ProductCategory", b =>
                {
                    b.Property<int>("ProductCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Pidd")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("ProductCategoryId");

                    b.ToTable("EX_ProductCategory");
                });

            modelBuilder.Entity("WMS.Models.EX_ReservoirArea", b =>
                {
                    b.Property<int>("ReservoirAreaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Remark")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Rname")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("TemperatureZone")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<int>("WIdd")
                        .HasColumnType("int");

                    b.HasKey("ReservoirAreaId");

                    b.ToTable("EX_ReservoirArea");
                });

            modelBuilder.Entity("WMS.Models.EX_Warehouse", b =>
                {
                    b.Property<int>("WarehouseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Wname")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("WarehouseId");

                    b.ToTable("EX_Warehouse");
                });

            modelBuilder.Entity("WMS.Models.EX_Zhy", b =>
                {
                    b.Property<int>("ZhyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("InventorySettings")
                        .HasColumnType("int");

                    b.Property<int>("Ridd")
                        .HasColumnType("int");

                    b.Property<string>("TemperatureZone")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Zname")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("ZhyId");

                    b.ToTable("EX_Zhy");
                });

            modelBuilder.Entity("WMS.Models.EX_supplier", b =>
                {
                    b.Property<int>("SupplierId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Serial")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("SupplierName")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("SupplierId");

                    b.ToTable("EX_supplier");
                });

            modelBuilder.Entity("WMS.Models.Ex_GoodsOne", b =>
                {
                    b.Property<int>("Ex_GoodsOneId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Coding")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<DateTime>("Createtime")
                        .HasColumnType("datetime2");

                    b.Property<string>("GOname")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<int>("ONEsum")
                        .HasColumnType("int");

                    b.Property<int>("Pidd")
                        .HasColumnType("int");

                    b.Property<string>("PurchasePerson")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.Property<int>("Supplier")
                        .HasColumnType("int")
                        .HasMaxLength(200);

                    b.HasKey("Ex_GoodsOneId");

                    b.ToTable("Ex_GoodsOne");
                });

            modelBuilder.Entity("WMS.Models.Ex_GoodsTWO", b =>
                {
                    b.Property<int>("Ex_GoodsTWOId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Coding")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<int>("EX_ZhyId")
                        .HasColumnType("int");

                    b.Property<string>("GWname")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<int>("OneIdd")
                        .HasColumnType("int");

                    b.Property<string>("Specification")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<int>("TWOsum")
                        .HasColumnType("int");

                    b.HasKey("Ex_GoodsTWOId");

                    b.ToTable("Ex_GoodsTWO");
                });

            modelBuilder.Entity("WMS.Models.Ex_GoodsThr", b =>
                {
                    b.Property<int>("GoodsThId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Coding")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<int>("GTname")
                        .HasColumnType("int")
                        .HasMaxLength(200);

                    b.Property<int>("Specification")
                        .HasColumnType("int")
                        .HasMaxLength(200);

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.Property<int>("TWOIdd")
                        .HasColumnType("int");

                    b.HasKey("GoodsThId");

                    b.ToTable("Ex_GoodsThr");
                });

            modelBuilder.Entity("WMS.Models.Godown", b =>
                {
                    b.Property<int>("GodownId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GodownRegisterId")
                        .HasColumnType("int");

                    b.HasKey("GodownId");

                    b.ToTable("Godowns");
                });

            modelBuilder.Entity("WMS.Models.Goods", b =>
                {
                    b.Property<int>("GoodsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Conding")
                        .HasColumnType("int")
                        .HasMaxLength(200);

                    b.Property<string>("Gname")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<int>("InventorySettings")
                        .HasColumnType("int");

                    b.Property<int>("level")
                        .HasColumnType("int");

                    b.HasKey("GoodsId");

                    b.ToTable("Goods");
                });

            modelBuilder.Entity("WMS.Models.Itemdetails", b =>
                {
                    b.Property<int>("IId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IApply")
                        .HasColumnType("int");

                    b.Property<int>("IExamine")
                        .HasColumnType("int");

                    b.Property<int>("IHaveoutbound")
                        .HasColumnType("int");

                    b.Property<int>("IInventory")
                        .HasColumnType("int");

                    b.Property<string>("IItemcode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("IMoney")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("IName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IPicture")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("IPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ISum")
                        .HasColumnType("int");

                    b.Property<string>("IUnits")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IWId")
                        .HasColumnType("int");

                    b.HasKey("IId");

                    b.ToTable("Itemdetailss");
                });

            modelBuilder.Entity("WMS.Models.Notarize", b =>
                {
                    b.Property<int>("NId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NCoding")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("NName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NOdd")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NOutlet")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NPerson")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NQuantity")
                        .HasColumnType("int");

                    b.Property<string>("NSCoding")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NSpecification")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NState")
                        .HasColumnType("int");

                    b.Property<int>("NWId")
                        .HasColumnType("int");

                    b.Property<string>("NWarm")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NId");

                    b.ToTable("Notarizes");
                });

            modelBuilder.Entity("WMS.Models.Print", b =>
                {
                    b.Property<int>("PId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PBatch")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PCategory")
                        .HasColumnType("int");

                    b.Property<string>("PCoding")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PPerson")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PQuantity")
                        .HasColumnType("int");

                    b.Property<string>("PSpecification")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("PUnit")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PWId")
                        .HasColumnType("int");

                    b.HasKey("PId");

                    b.ToTable("Prints");
                });

            modelBuilder.Entity("WMS.Models.Purchase", b =>
                {
                    b.Property<int>("PurchaseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PurchaseGoodsId")
                        .HasColumnType("int");

                    b.Property<string>("PurchaseName")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("PurchaseNum")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<int>("PurchaseState")
                        .HasColumnType("int");

                    b.Property<int>("PurchaseSupplierId")
                        .HasColumnType("int");

                    b.Property<DateTime>("PurchaseTime")
                        .HasColumnType("datetime2");

                    b.HasKey("PurchaseId");

                    b.ToTable("Purchases");
                });

            modelBuilder.Entity("WMS.Models.SendTheShipping", b =>
                {
                    b.Property<int>("SId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("SAmount")
                        .HasColumnType("int");

                    b.Property<string>("SNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SRemind")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SWId")
                        .HasColumnType("int");

                    b.Property<string>("SWarm")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SId");

                    b.ToTable("SendTheShippings");
                });

            modelBuilder.Entity("WMS.Models.Students", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Students");
                });
#pragma warning restore 612, 618
        }
    }
}