using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WMS.Dtos;
using WMS.List;

namespace WMS.Helper
{
    public class PHelper
    {
        public List<InventoryDto> Inventory_List { get; set; }
        public List<ReservoirAreaDto> ReservoirArea_list { get; set; }
        public List<GoodsAllocationDto> WRZ_list { get; set; }
        public List<WareHouseKeeperDto> WareHouseKeeperDto { get; set; }
        public List<KeeperDto> KeeperDto { get; set; }
        public int totalCount { get; set; }
        public int pageIndex { get; set; }
        public int pageSize { get; set; }
    }
}
