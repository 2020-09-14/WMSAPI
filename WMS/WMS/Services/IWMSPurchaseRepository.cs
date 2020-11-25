using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WMS.Models;
using WMS.List;
using WMS.Dtos;

namespace WMS.Services
{
   public interface IWMSPurchaseRepository
    {
        IEnumerable<Purchase_list> GetPurchases();


        IEnumerable<Goods> ShangGoods();
        //接口写了个删除方法
        int Shan(string ids);




        


        IEnumerable<Purchase_list> GetPurchasesId();

        IEnumerable<EX_supplier> GetEnumerablesupplier();
        IEnumerable<Ex_GoodsTWO> GetEx_GoodsTWO();

        IEnumerable<GodownTodoId_list> godownTodoId_Lists();
        void AddPurchase(Purchase purchase);
        void UptPurchase(int ids);
        bool Save();

    }
}
