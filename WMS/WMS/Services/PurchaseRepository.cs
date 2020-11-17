﻿using Microsoft.EntityFrameworkCore;
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

        public void AddPurchase(Purchase purchase)
        {
            if (purchase == null)
            {
                throw new ArgumentException(nameof(purchase));
            }
            _appDbContext.Purchases.Add(purchase);
            _appDbContext.SaveChanges();
        }

        public IEnumerable<EX_supplier> GetEnumerablesupplier()
        {
            return  _appDbContext.EX_supplier;
        }

        public IEnumerable<Ex_GoodsTWO> GetEx_GoodsTWO()
        {
            return _appDbContext.Ex_GoodsTWO;
        }

        public IEnumerable<Purchase_list> GetPurchases()
        {
           

            var aa = from b in _appDbContext.Set<Purchase>()
                        join p in _appDbContext.Set<EX_supplier>()
                            on b.PurchaseSupplierId equals p.SupplierId
                            join c in _appDbContext.Set<Ex_GoodsTWO>()
                            on b.PurchaseGoodsId equals c.OneIdd
                        select new { 
                            b.PurchaseGoodsId   ,
                            b.PurchaseId        ,
                            b.PurchaseNum       ,
                            b.PurchaseSupplierId,
                            b.PurchaseTime      ,  
                            b.PurchaseName      ,
                            b.PurchaseState,
                            p.SupplierName, 
                            p.Serial ,
                            p.SupplierId ,
                            c.Ex_GoodsTWOId,
                            c.GWname    ,  
                            c.Specification,
                            c.OneIdd       ,
                            c.Coding       ,
                            c.TWOsum       ,
                            c.EX_ZhyId
                          
                        };
            
            //if (!string.IsNullOrWhiteSpace(ccc))
            //{
            //    ccc = ccc.Trim();
            //    aa=aa.Where()
            //}
            string str = JsonConvert.SerializeObject(aa);
            IEnumerable<Purchase_list> bb = JsonConvert.DeserializeObject<IEnumerable<Purchase_list>>(str);
            return bb;
            //return await _appDbContext.Purchases.Include(s => s.PurchaseSupplierId).ToListAsync();

        }

        public IEnumerable<Purchase_list> GetPurchasesId()
        {
            var aa = from b in _appDbContext.Set<Purchase>()
                     join p in _appDbContext.Set<EX_supplier>()
                         on b.PurchaseSupplierId equals p.SupplierId
                     join c in _appDbContext.Set<Ex_GoodsTWO>()
                     on b.PurchaseGoodsId equals c.OneIdd
                     select new
                     {
                         b.PurchaseGoodsId,
                         b.PurchaseId,
                         b.PurchaseNum,
                         b.PurchaseSupplierId,
                         b.PurchaseTime,
                         b.PurchaseName,
                         b.PurchaseState,
                         p.SupplierName,
                         p.Serial,
                         p.SupplierId,
                         c.Ex_GoodsTWOId,
                         c.GWname,
                         c.Specification,
                         c.OneIdd,
                         c.Coding,
                         c.TWOsum,
                         c.EX_ZhyId

                     };

            //if (!string.IsNullOrWhiteSpace(ccc))
            //{
            //    ccc = ccc.Trim();
            //    aa=aa.Where()
            //}
            string str = JsonConvert.SerializeObject(aa);
            IEnumerable<Purchase_list> bb = JsonConvert.DeserializeObject<IEnumerable<Purchase_list>>(str);
            return bb;
        }

        public bool Save()
        {
            return  _appDbContext.SaveChanges() >= 0;
        }
    }
}
