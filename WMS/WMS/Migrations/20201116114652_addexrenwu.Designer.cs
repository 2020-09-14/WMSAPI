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
    [Migration("20201116114652_addexrenwu")]
    partial class addexrenwu
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

            modelBuilder.Entity("WMS.Models.EX_Renwu", b =>
                {
                    b.Property<int>("ShipmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cause")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<DateTime>("Createtime")
                        .HasColumnType("datetime2");

                    b.Property<int>("Goodsidd")
                        .HasColumnType("int");

                    b.Property<string>("ShCoding")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<int>("Shsum")
                        .HasColumnType("int");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.Property<string>("article")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("ShipmentId");

                    b.ToTable("EX_Renwus");
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

            modelBuilder.Entity("WMS.Models.EX_Shipment", b =>
                {
                    b.Property<int>("ShipmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cause")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<DateTime>("Createtime")
                        .HasColumnType("datetime2");

                    b.Property<int>("Goodsidd")
                        .HasColumnType("int");

                    b.Property<string>("ShCoding")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<int>("Shsum")
                        .HasColumnType("int");

                    b.Property<int>("SupplierIdd")
                        .HasColumnType("int");

                    b.Property<string>("article")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("ShipmentId");

                    b.ToTable("EX_Shipment");
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
