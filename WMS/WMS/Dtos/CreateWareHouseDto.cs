using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WMS.Dtos
{
    public class CreateWareHouseDto
    {
        public int WarehouseId { get; set; }
        public string Wname { get; set; }
        public string Address { get; set; }
    }
}
