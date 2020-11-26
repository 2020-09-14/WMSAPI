using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WMS.Dtos
{
    public class WareHouseKeeperDto
    {
        //库管员表
        public int WareHouserKeeperId { get; set; }
        public string KeeperName { get; set; }//姓名
        public string KeeperPhone { get; set; }//手机号
        public DateTime CreateTime { get; set; }//创建时间
        public int State { get; set; }//状态
        public int WId { get; set; }//仓库外键
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
    }
}
