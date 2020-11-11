using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WMS.List
{
    public class AOGregister_List
    {
        public int AOGId { get; set; }
        public int AOGPurchase { get; set; }
        public int AOGState { get; set; }
        public int AOGNum { get; set; }
        public int AOGWarehouse { get; set; }
        public string AOGRemark { get; set; }
        public int PurchaseId { get; set; }
        public string PurchaseNum { get; set; }
        public int PurchaseSupplierId { get; set; }
        public DateTime PurchaseTime { get; set; }
        public string PurchaseName { get; set; }
        public int PurchaseGoodsId { get; set; }
        public int PurchaseState { get; set; }


        public int SupplierId { get; set; }

        public string SupplierName { get; set; }

        public string Serial { get; set; }

        public int Ex_GoodsTWOId { get; set; }
        public string GWname { get; set; }
        public string Specification { get; set; }
        public int OneIdd { get; set; }
        public string Coding { get; set; }
        public int TWOsum { get; set; }
        public int EX_ZhyId { get; set; }
    }
}
