using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WMS.List;
using WMS.Models;
using WMS.Database;
using Newtonsoft.Json;
using WMS.Dtos;

namespace WMS.Services
{
    public class EX_Wangchaolist:EX_Wangchao
    {
        private AppDbContext _appDbContext;
        public EX_Wangchaolist(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        //添加出库任务
        public int Ex_AddChukuwupin(List<EX_GoodsOutbound> list, string ids)
        {
            int jilu=0;
            for (int i = 0; i < list.Count-1; i++)
            {
                //list[i].GoodsOId = 0;
                list[i].RenIdd = Convert.ToInt32(ids);
                _appDbContext.EX_GoodsOutbounds.Add(list[i]);
                jilu += _appDbContext.SaveChanges();

            }
            //foreach (EX_GoodsOutbound item in list)
            //{
            //    
            //    item.RenIdd = Convert.ToInt32(ids);
               
            //}
            
            return jilu;
        }
        public bool Save()
        {
            return _appDbContext.SaveChanges() > 0;
        }
        //显示所有库存商品，方便用户选择
        public IEnumerable<Ex_GoodsTWO> Ex_GoodsTWOs()
        {
            return _appDbContext.Ex_GoodsTWO.ToList();
        }

        public IEnumerable<EX_ProductCategory> EX_ProductCategories()
        {
            //IQueryable<EX_ProductCategory> aa = _appDbContext.EX_ProductCategory;
            //aa=aa.Where()
            return _appDbContext.EX_ProductCategory.ToList();
            //var aa = from a in _appDbContext.Set<EX_ProductCategory>()
            //         select new
            //         {
            //             a.ProductCategoryId,
            //             a.Pidd,
            //             a.ProductName
            //         };
            
        }
        //任务单
        public IEnumerable<EX_Renwu> EX_Renwus()
        {
            var aa = from a in _appDbContext.Set<EX_Renwu>()
                     select new
                     {
                         a.article,
                         a.Cause,
                         a.Createtime,
                         a.Goodsidd,
                         a.ShCoding,
                         a.ShipmentId,
                         a.Shsum,
                         a.State
                     };
            string str = JsonConvert.SerializeObject(aa);
            IEnumerable<EX_Renwu> bb = JsonConvert.DeserializeObject<IEnumerable<EX_Renwu>>(str);
            return bb;
        }
        //先添加出库任务，并返回任务的东西
        public IEnumerable<EX_Renwu> EX_Renwus(EX_Renwu _Renwu)
        {
            _appDbContext.EX_Renwus.Add(_Renwu);
            _appDbContext.SaveChanges();
            return _appDbContext.EX_Renwus.Where(s=>s.ShCoding==_Renwu.ShCoding); 
        }

        public IEnumerable<EX_Shipment_list> EX_Shipments()
        {
            var aa = from b in _appDbContext.Set<EX_Shipment>()
                     join p in _appDbContext.Set<EX_supplier>()
                         on b.ShipmentId equals p.SupplierId
                     select new
                     {
                         b.ShipmentId,
                       
                         
                         b.ShCoding
                         ,
                         p.SupplierName
                         ,
                         p.Serial



                     };
            string str = JsonConvert.SerializeObject(aa);
            IEnumerable<EX_Shipment_list> bb = JsonConvert.DeserializeObject<IEnumerable<EX_Shipment_list>>(str);
            return bb;
        }
        //显示出库任务所对应的商品明细
        public IEnumerable<EX_GoodsOutbound> EX_GoodsOutboundsShow()
        {
            return _appDbContext.EX_GoodsOutbounds.ToList();
        }
        //显示日报表日期
        public IEnumerable<DailyStatement> DailyStatements()
        {
            return _appDbContext.DailyStatement.ToList();
        }
        //显示要打印的
        public IEnumerable<EX_RenwusList> EX_Renwus(string time)
        {
            var aa = from a in _appDbContext.Set<EX_Renwu>()
                     join b in _appDbContext.Set<EX_GoodsOutbound>()
                     on a.ShipmentId equals b.GoodsOId
                     select new
                     {
                         a.ShipmentId,
                         a.ShCoding,
                         a.Goodsidd,
                         a.Shsum,
                         a.State,
                         a.article,
                         a.Cause,
                         a.Createtime,
                         b.GoCoding,
                         b.GoName,
                         b.GoodsOId,
                         b.GoSpecification,
                         b.Gosum,
                         b.RenIdd
                         
                     };
            string str = JsonConvert.SerializeObject(aa);
            IEnumerable<EX_RenwusList> bb = JsonConvert.DeserializeObject<IEnumerable<EX_RenwusList>>(str);
            return bb;
        }
    }
}
