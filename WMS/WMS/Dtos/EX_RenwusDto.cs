using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WMS.Dtos
{
    public class EX_RenwusDto
    {

        public int ShipmentId { get; set; }
    
        public string ShCoding { get; set; }
        public DateTime Createtime { get; set; }
        public int State { get; set; }
        public int Goodsidd { get; set; }
        public string Cause { get; set; }
        public string article { get; set; }
        public int Shsum { get; set; }
    }
}
