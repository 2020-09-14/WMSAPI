using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WMS.Dtos
{
    public class GoodsDto
    {
       
        public int GoodsId { get; set; }
     
        public int Conding { get; set; }

        public int InventorySettings { get; set; }

     
        public string Gname { get; set; }

        public int level { get; set; }
    }
}
