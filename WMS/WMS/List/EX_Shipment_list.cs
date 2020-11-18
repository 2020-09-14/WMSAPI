using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WMS.List
{
    [NotMapped]
    public class EX_Shipment_list
    {
        public int ShipmentId { get; set; }

        public string ShCoding { get; set; }
        public DateTime Createtime { get; set; }


        public int Goodsidd { get; set; }//完成状态
        public int MyProperty { get; set; }//商品外键



        //供应商

        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string Serial { get; set; }

        //二级的商品
        public int Ex_GoodsTWOId { get; set; }
        public string GWname { get; set; }
        public string Specification { get; set; }


        public int OneIdd { get; set; }
        public int TWOsum { get; set; }
        public string Coding { get; set; }
        public int EX_ZhyId { get; set; }
    }
}
