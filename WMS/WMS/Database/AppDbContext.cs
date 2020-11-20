using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WMS.List;
using WMS.Models;

namespace WMS.Database
{
    public class AppDbContext :DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }
        public DbSet<Students> Students { get; set; }

        public DbSet<DailyStatement> DailyStatement { get; set; }

        public DbSet<Ex_GoodsOne> Ex_GoodsOne { get; set; }

        public DbSet<Ex_GoodsThr> Ex_GoodsThr { get; set; }

        public DbSet<Ex_GoodsTWO> Ex_GoodsTWO { get; set; }

        public DbSet<EX_ProductCategory> EX_ProductCategory { get; set; }

        public DbSet<EX_ReservoirArea> EX_ReservoirArea { get; set; }

        public DbSet<EX_supplier> EX_supplier { get; set; }
        public DbSet<EX_Shipment> EX_Shipment { get; set; }
      
        public DbSet<EX_Warehouse> EX_Warehouse { get; set; }

        public DbSet<EX_Zhy> EX_Zhy { get; set; }
        public DbSet<Goods> Goods { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<Purchase_list> Purchase_Lists { get; set; }
        public DbSet<AOGregister>  AOGregisters { get; set; }
        public DbSet<AOGQualityTest>  AOGQualityTests { get; set; }
        public DbSet<Godown>  Godowns { get; set; }


        public DbSet<Allot> Allots { get; set; }
        public DbSet<BStorage> BStorages { get; set; }
        public DbSet<Details> Detailss { get; set; }
        public DbSet<EDispose> EDisposes { get; set; }
        public DbSet<Itemdetails> Itemdetailss { get; set; }
        public DbSet<Notarize> Notarizes { get; set; }
        public DbSet<Print> Prints { get; set; }
        public DbSet<SendTheShipping> SendTheShippings { get; set; }

        public DbSet<GodownTodo>  GodownTodos { get; set; }

        public DbSet<EX_Shipment_list> EX_Shipment_Lists { get; set; }
        public DbSet<EX_ProductCategory> EX_ProductCategories { get; set; }
        public DbSet<EX_Renwu> EX_Renwus { get; set; }
        public DbSet<EX_GoodsOutbound> EX_GoodsOutbounds { get; set; }


    }
}
