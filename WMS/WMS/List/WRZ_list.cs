using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WMS.List
{
    [NotMapped]
    public class WRZ_list
    {
        //主仓库
        public int WarehouseId { get; set; }
        public string Wname { get; set; }//仓库名
        public string Address { get; set; }//仓库地址
        //库区
        public int ReservoirAreaId { get; set; }
        public string Rname { get; set; }
        public string Remark { get; set; }
        public string TemperatureZone { get; set; }
        public int WIdd { get; set; }
        //货位
        public int ZhyId { get; set; }
        public string Zname { get; set; }
        public int Ridd { get; set; }
        public int InventorySettings { get; set; }
    }
}
