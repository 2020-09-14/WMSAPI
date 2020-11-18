using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WMS.Models
{
    public class EX_Shipment
    {
        //出库表
        [Key]
        public int ShipmentId { get; set; }
        [MaxLength(200)]
        public string ShCoding { get; set; }
        public DateTime Createtime { get; set; }
        public int SupplierIdd { get; set; }


        public int Goodsidd { get; set; }//商品外键
        [MaxLength(200)]
        public string Cause { get; set; }//出库原因
        [MaxLength(200)]
        public string article { get; set; }//出库为物品
        public int Shsum { get; set; }//任务数量
    }
}
