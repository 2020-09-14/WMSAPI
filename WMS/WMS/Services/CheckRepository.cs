using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WMS.Database;
using WMS.Dtos;
using WMS.List;
using WMS.Models;

namespace WMS.Services
{
    public class CheckRepository : IWMSCheckRepository
    {
        private readonly AppDbContext _appDbContext;
        public CheckRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

       

        public IEnumerable<check_list> GetCheck()
        {
         

            var aaa = from a in _appDbContext.Set<Check>()
                     join b in _appDbContext.Set<Ex_GoodsTWO>()
                     on a.GoodsTWOIds equals b.Ex_GoodsTWOId
                     join c in _appDbContext.Set<EX_ProductCategory>()
                     on a.ProductCategoryIds equals c.ProductCategoryId
                     select new {
                         
                         a.CheckTaskId,
                         b.Coding,
                         c.ProductName,
                         b.GWname,
                         b.Specification,
                         b.TWOsum,
                         a.BatchNumber,
                         a.TermOfValidity,
                         a.GoodsAllocation
                     };

           
            string str = JsonConvert.SerializeObject(aaa);
            IEnumerable<check_list> bb = JsonConvert.DeserializeObject<IEnumerable<check_list>>(str);

            return bb;

        }

        public int  AddChecka(Check check)
        {
            Check check1 = new Check()
            {
                CheckTaskId = check.CheckTaskId,
                WareHouseName = check.WareHouseName,
                kQName = check.kQName,
                HjName = check.HjName,
                DefaultInventoryPeople = check.DefaultInventoryPeople,
                CheckTimes = check.CheckTimes,
                CheckDetail = check.CheckDetail
            };

            _appDbContext.Checks.Add(check);
          return  _appDbContext.SaveChanges();
            
        }

        public bool Save()
        {
            return _appDbContext.SaveChanges() >= 0;
        }

        //未完成
        public IEnumerable<Check> GetCheckNo()
        {

            return _appDbContext.Checks;
        }


        //已完成盘点单
        public IEnumerable<Check> GetCheckYes()
        {
            return _appDbContext.Checks;
        }

        //实盘的显示
        public IEnumerable<check_list> CheckShi()
        {
            var aaa = from a in _appDbContext.Set<Check>()
                      join b in _appDbContext.Set<Ex_GoodsTWO>()
                      on a.GoodsTWOIds equals b.Ex_GoodsTWOId
                      join c in _appDbContext.Set<EX_ProductCategory>()
                      on a.ProductCategoryIds equals c.ProductCategoryId
                      select new
                      {

                          a.CheckTaskId,
                          b.Coding,
                          c.ProductName,
                          b.GWname,
                          b.Specification,
                          a.BatchNumber,   
                          a.TermOfValidity,
                          a.GoodsAllocation,
                          b.TWOsum,
                          a.CheckNum
                      };


            string str = JsonConvert.SerializeObject(aaa);
            IEnumerable<check_list> bb = JsonConvert.DeserializeObject<IEnumerable<check_list>>(str);

            return bb;
        }

        public IEnumerable<Check> GetCheckShen()
        {
            return _appDbContext.Checks;
        }
    }
}
