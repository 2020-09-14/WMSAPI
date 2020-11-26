using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WMS.Dtos
{
    public class CreateGoodsAllocationDto
    {
        //货位
        public int ZhyId { get; set; }
        public string Zname { get; set; }
        public int Ridd { get; set; }
        public int InventorySettings { get; set; }
    }
}
