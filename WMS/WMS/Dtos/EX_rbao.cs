using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WMS.Dtos
{
    public class EX_rbao
    {
        //出库任务
        public int ShipmentId { get; set; }

        public string ShCoding { get; set; }
        public DateTime Createtime { get; set; }
        public int State { get; set; }
        public int Goodsidd { get; set; }

        public string Cause { get; set; }

        public string article { get; set; }
        public int Shsum { get; set; }



        //出库所对应的商品
        public int GoodsOId { get; set; }


        public string GoCoding { get; set; }
        public int Gosum { get; set; }
        public string GoName { get; set; }


        public string GoSpecification { get; set; }
        public int RenIdd { get; set; }
    }
}
