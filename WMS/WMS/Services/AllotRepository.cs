using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WMS.Database;
using WMS.List;
using WMS.Models;

namespace WMS.Services
{
    public class AllotRepository : IWMSAllot
    {
        private readonly AppDbContext _appDbContext;
        public AllotRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        //单删调拨列表
        //public IEnumerable<Allot> DelAllot()
        //{
            
        //}
        //显示调拨入库
            public IEnumerable<BStorage> GetBStorages()
        {
            return _appDbContext.BStorages;
        }

        //显示调入处理
        public IEnumerable<EDispose> GetEDisposes()
        {
            return _appDbContext.EDisposes;
        }

        //显示调拨物品详情
        public IEnumerable<Itemdetails_List> GetItemdetails()
        {
            var aa = from i in _appDbContext.Set<Itemdetails>()
                     join g in _appDbContext.Set<Goods>()
                     on i.IWId equals g.GoodsId
                     select new
                     {
                         i.IId,
                         g.Conding,
                         g.Gname,
                         i.IInventory,
                         i.IApply,
                         i.IExamine,
                         i.IHaveoutbound,
                         i.IUnits,
                         i.IPrice
                     };
            string str = JsonConvert.SerializeObject(aa);
            IEnumerable<Itemdetails_List> bb = JsonConvert.DeserializeObject<IEnumerable<Itemdetails_List>>(str);
            return bb;
        }
        //查看
        public IEnumerable<Itemdetails_List> GetItemdetailsCK()
        {
            var aa = from i in _appDbContext.Set<Itemdetails>()
                     join g in _appDbContext.Set<Goods>()
                     on i.IWId equals g.GoodsId
                     select new
                     {
                         i.IId,
                         g.Conding,
                         g.Gname,
                         g.InventorySettings,
                         i.IApply,
                         i.IExamine,
                         i.IUnits,
                         i.IPrice,
                         i.IMoney
                     };
            string str = JsonConvert.SerializeObject(aa);
            IEnumerable<Itemdetails_List> bb = JsonConvert.DeserializeObject<IEnumerable<Itemdetails_List>>(str);
            return bb;
        }

        //审核
        public IEnumerable<Itemdetails_List> GetItemdetailsSH()
        {
            var aa = from i in _appDbContext.Set<Itemdetails>()
                     join g in _appDbContext.Set<Goods>()
                     on i.IWId equals g.GoodsId
                     select new
                     {
                         i.IId,
                         g.Conding,
                         g.Gname,
                         g.InventorySettings,
                         i.ISum,
                         i.IApply,
                         i.IExamine,
                         i.IUnits,
                         i.IPrice,
                         i.IMoney
                     };
            string str = JsonConvert.SerializeObject(aa);
            IEnumerable<Itemdetails_List> bb = JsonConvert.DeserializeObject<IEnumerable<Itemdetails_List>>(str);
            return bb;
        }

        //显示发配送区
        public IEnumerable<SendTheShipping> GetSendTheShippings()
        {
            return _appDbContext.SendTheShippings;
        }

        //显示调拨单列表
        public IEnumerable<Allot> GetShowAllot()
        {
            return _appDbContext.Allots;
        }
        //显示补货单号
        public IEnumerable<Details_List> GetShowBH()
        {
            var aa = from d in _appDbContext.Set<Details>()
                     join r in _appDbContext.Set<EX_Renwu>()
                     on d.DWId equals r.ShipmentId
                     select new
                     {
                         r.ShipmentId,
                         r.ShCoding,
                         r.Createtime
                     };
            string str = JsonConvert.SerializeObject(aa);
            IEnumerable<Details_List> bb = JsonConvert.DeserializeObject<IEnumerable<Details_List>>(str);
            return bb;
        }

        //显示补货详情
        public IEnumerable<Details_List> GetShowDetails()
        {
            var aa = from d in _appDbContext.Set<Details>()
                     join p in _appDbContext.Set<EX_ProductCategory>()
                     on d.DWId equals p.ProductCategoryId
                     join g in _appDbContext.Set<Ex_GoodsTWO>()
                     on p.Pidd equals g.Ex_GoodsTWOId
                     select new
                     {
                         p.ProductName,
                         g.GWname,
                         g.Coding,
                         g.Specification,
                         d.DPrice,
                         d.DAmount,
                         g.TWOsum,
                         d.DTotal,
                         d.DAudit,
                         d.DTotalNum,
                         d.DComparison,
                         d.DClose
                     };
            string str = JsonConvert.SerializeObject(aa);
            IEnumerable<Details_List> bb = JsonConvert.DeserializeObject<IEnumerable<Details_List>>(str);
            return bb;
        }

        //显示发配区
        public IEnumerable<SendTheShipping_List> GetShowSendTheShipping()
        {
            var aa = from s in _appDbContext.Set<SendTheShipping>()
                     join g in _appDbContext.Set<Ex_GoodsOne>()
                     on s.SWId equals g.Ex_GoodsOneId
                     select new
                     {
                         s.SId,
                         s.SNumber,
                         s.SWarm,
                         g.ONEsum,
                         s.SRemind,
                         g.State
                     };
            string str = JsonConvert.SerializeObject(aa);
            IEnumerable<SendTheShipping_List> bb = JsonConvert.DeserializeObject<IEnumerable<SendTheShipping_List>>(str);
            return bb;
        }

        //显示入库确定
        public IEnumerable<Notarize> Notarizes()
        {
            return _appDbContext.Notarizes;
        }
    }
}
