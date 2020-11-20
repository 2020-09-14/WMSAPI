using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WMS.Models
{
    public class SendTheShipping                      //发配送区
    {                    
        [Key]
        public int SId { get; set; }                  //序号
        [Required]
        public string SNumber { get; set; }           //周转筐编号
        [Required]
        public string SWarm { get; set; }             //温区
        [Required]
        public int SAmount { get; set; }              //商品数量
        [Required]
        public string SRemind { get; set; }           //配送自提点
        [Required]
        public int SWId { get; set; }                 //外键
    }
}
