using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WMS.Dtos;

namespace WMS.Helper
{
    public class PHelper
    {
        public List<InventoryDto> Inventory_List { get; set; }
        public List<ReservoirAreaDto> ReservoirArea_list { get; set; }
        public int totalCount { get; set; }
        public int pageIndex { get; set; }
        public int pageSize { get; set; }
    }
}
