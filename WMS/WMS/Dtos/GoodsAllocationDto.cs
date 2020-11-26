using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WMS.Dtos
{
    public class GoodsAllocationDto
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
