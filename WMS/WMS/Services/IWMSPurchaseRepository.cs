using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WMS.Models;
using WMS.List;
namespace WMS.Services
{
   public interface IWMSPurchaseRepository
    {
        IEnumerable<Purchase_list> GetPurchases();
    }
}
