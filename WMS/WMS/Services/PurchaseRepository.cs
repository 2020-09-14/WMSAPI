using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
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
            string str = JsonConvert.SerializeObject(aa);
            IEnumerable<Purchase_list> bb = JsonConvert.DeserializeObject<IEnumerable<Purchase_list>>(str);
            return bb;
        }


        public int Shan(string ids)
        {
            Goods goods = new Goods() { GoodsId = Convert.ToInt32(ids) };
            _appDbContext.Goods.Attach(goods);
            _appDbContext.Goods.Remove(goods);
         //保存
            return 
            _appDbContext.SaveChanges();
        }

        public IEnumerable<Goods> ShangGoods()
        {
            return _appDbContext.Goods.ToList();
        }
                                                                 
        public bool Save()
        {
            return  _appDbContext.SaveChanges() >= 0;
        }

        public void UptPurchase(int ids)
        {
           var aa= _appDbContext.Purchases.Where(s => s.PurchaseId.Equals(ids)).FirstOrDefault();
            aa.PurchaseState = 1;
            _appDbContext.SaveChanges();
            AddTodo(ids);
        }
        public void AddTodo(int ids)
        {
            var rand = "TD" + (DateTime.Now).ToString("yyyyMMdd");
            for (int i = 0; i < 1; i++)
            {
                Random rd = new Random();
                rand += rd.Next().ToString();
            }
            GodownTodo todo = new GodownTodo();
            todo.GodownTodoNum = rand;
            todo.GodownTodoPurchaseId = ids;
            todo.GodownTodoState = 0;

           
        }

        public IEnumerable<Purchase_list> GetPurchasesId()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<GodownTodoId_list> godownTodoId_Lists()
        {
            var aa = from a in _appDbContext.Set<GodownTodo>()
                    join b in _appDbContext.Set<Purchase>()
                        on a.GodownTodoPurchaseId equals b.PurchaseId
                     join p in _appDbContext.Set<EX_supplier>()
                         on b.PurchaseSupplierId equals p.SupplierId
                     join c in _appDbContext.Set<Ex_GoodsTWO>()
                     on b.PurchaseGoodsId equals c.OneIdd
                     select new
                     {
                         a.GodownTodoId,
                         a.GodownTodoNum,
                         a.GodownTodoPurchaseId,
                         a.GodownTodoState,
                         a.GodownWarehouse,
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
            string str = JsonConvert.SerializeObject(aa);
            IEnumerable<GodownTodoId_list> bb = JsonConvert.DeserializeObject<IEnumerable<GodownTodoId_list>>(str);
            return bb;
        }

        public void UptGodown(GodownTodo godownTodo)
        {
            var aa = _appDbContext.GodownTodos.Where(s => s.GodownTodoId.Equals(godownTodo.GodownTodoId)).FirstOrDefault();
            aa.GodownTodoState = 2;
            aa.GodownWarehouse = godownTodo.GodownWarehouse;
            _appDbContext.SaveChanges();
           
        }
        public IEnumerable<Cangkulian> aaa()
        {
            var aa = from a in _appDbContext.Set<GodownTodo>()
                     join b in _appDbContext.Set<Purchase>()
                         on a.GodownTodoPurchaseId equals b.PurchaseId
                     join p in _appDbContext.Set<EX_supplier>()
                         on b.PurchaseSupplierId equals p.SupplierId
                     join c in _appDbContext.Set<Ex_GoodsTWO>()
                     on b.PurchaseGoodsId equals c.OneIdd 
                     join e in _appDbContext.Set<EX_Warehouse>() on a.GodownWarehouse equals e.WarehouseId join f in _appDbContext.Set<EX_ReservoirArea>() on e.WarehouseId equals f.WIdd join g in _appDbContext.Set<EX_Zhy>() on f.ReservoirAreaId equals g.Ridd
                     select new
                     {
                         a.GodownTodoId,
                         a.GodownTodoNum,
                         a.GodownTodoPurchaseId,
                         a.GodownTodoState,
                         a.GodownWarehouse,
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
                         c.EX_ZhyId,
                         e.Wname,
                         f.Rname,
                         g.Zname

                     };
            
            string str = JsonConvert.SerializeObject(aa);
        IEnumerable<Cangkulian> bb = JsonConvert.DeserializeObject<IEnumerable<Cangkulian>>(str);
            return bb;
            
        }
    }

}
