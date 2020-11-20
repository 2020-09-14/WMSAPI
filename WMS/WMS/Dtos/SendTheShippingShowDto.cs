using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WMS.Dtos
{
    public class SendTheShippingShowDto
    {

        public int SId { get; set; }                  //序号
 
        public string SNumber { get; set; }           //周转筐编号

        public string SWarm { get; set; }             //温区

        public int SAmount { get; set; }              //商品数量

        public string SRemind { get; set; }           //配送自提点

        public int SWId { get; set; }                 //外键
    }
}
