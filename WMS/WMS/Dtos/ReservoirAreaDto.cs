using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WMS.Dtos
{
    public class ReservoirAreaDto
    {
        //主仓库
        public int WarehouseId { get; set; }
        public string Wname { get; set; }//仓库名
        public string Address { get; set; }//仓库地址

        //库区
        public int ReservoirAreaId { get; set; }
        public string Rname { get; set; }//库区名
        public string Remark { get; set; }//库区备注
        public string TemperatureZone { get; set; }//所属温区
        public int WIdd { get; set; }//主仓库外键
    }
}
