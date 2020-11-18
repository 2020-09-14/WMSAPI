using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WMS.Dtos
{
    public class EX_GoodsOutboundDto
    {
      
        public int GoodsOId { get; set; }

    
        public string GoCoding { get; set; }
        public int Gosum { get; set; }
        public string GoName { get; set; }
       
        public string GoSpecification { get; set; }
        public int RenIdd { get; set; }
    }
}
