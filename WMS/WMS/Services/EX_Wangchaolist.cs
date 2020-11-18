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
            int i=0;
            foreach (EX_GoodsOutbound item in list)
            {
                item.GoodsOId = 0;
                item.RenIdd = Convert.ToInt32(ids);
                _appDbContext.EX_GoodsOutbounds.Add(item);
               i +=  _appDbContext.SaveChanges();
            }
            
            return i;
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

     
    }
}
