using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WMS.Dtos
{
    public class CreatePurchaseDto
    {
        public string PurchaseNum { get; set; }
        public int PurchaseSupplierId { get; set; }
        public DateTime PurchaseTime { get; set; }
       
        public string PurchaseName { get; set; }
        public int PurchaseGoodsId { get; set; }
        public int PurchaseState { get; set; }
    }
}
