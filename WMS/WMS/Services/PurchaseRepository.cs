using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using WMS.Database;
using WMS.Models;
using Newtonsoft.Json;
using WMS.List;

namespace WMS.Services
{
    public class PurchaseRepository : IWMSPurchaseRepository
    {
        private readonly AppDbContext _appDbContext;
        public PurchaseRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Purchase_list> GetPurchases()
        {
            //IQueryable<Purchase> iq = _appDbContext.Purchases.Include("EX_supplier");
            //IQueryable<Purchase> result = _appDbContext.Purchases.Include(t => t.PurchaseSupplierId);

            //var re = (from o in _appDbContext.Purchases
            //          join d in _appDbContext.EX_supplier
            //          on o.PurchaseSupplierId equals d.SupplierId
            //          join p in _appDbContext.Ex_GoodsTWO
            //          on o.PurchaseGoodsId equals p.Ex_GoodsTWOId
            //          select new
            //          {
            //              d.SupplierName,
            //          });
            //var aa = _appDbContext.Purchase_Lists.FromSqlRaw("select * from Purchases join EX_supplier on PurchaseSupplierId=SupplierId join Ex_GoodsTWO on PurchaseGoodsId=Ex_GoodsTWO.OneIdd");
            var aa = from b in _appDbContext.Set<Purchase>()
                        join p in _appDbContext.Set<EX_supplier>()
                            on b.PurchaseSupplierId equals p.SupplierId
                        select new { b.PurchaseGoodsId,p.SupplierId };
            string str = JsonConvert.SerializeObject(aa);
            IEnumerable<Purchase_list> bb = JsonConvert.DeserializeObject<IEnumerable<Purchase_list>>(str);
            return bb;
            //return await _appDbContext.Purchases.Include(s => s.PurchaseSupplierId).ToListAsync();

        }
    }
}
