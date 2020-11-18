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


        IEnumerable<Purchase_list> GetPurchasesId();
        IEnumerable<EX_supplier> GetEnumerablesupplier();
        IEnumerable<Ex_GoodsTWO> GetEx_GoodsTWO();
        void AddPurchase(Purchase purchase);
        bool Save();
    }
}
