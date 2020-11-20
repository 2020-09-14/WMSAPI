using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WMS.Models
{
    public class BStorage                                  //调拨入库 
    {                      
        [Key]
        public int BId { get; set; }                       //行号
        [Required]
        public string BEntry { get; set; }                 //调拨入库单号
        [Required]
        public string BTS { get; set; }                    //TS调入单号
        [Required]
        public string BWarehouse { get; set; }             //调出仓库
        [Required]
        public string BFold { get; set; }                  //调入仓库
        [Required]
        public DateTime BSend { get; set; }                //发送日期
        [Required]
        public DateTime BEnter { get; set; }               //入库日期
        [Required]
        public string BWarm { get; set; }                  //温区
        [Required]
        public int BSum { get; set; }                      //商品总数
        [Required]
        public string BPerson { get; set; }                //调拨人
        [Required]
        public string BConsignee { get; set; }             //收货人
        [Required]
        public int BWId { get; set; }                      //外键
    }
}
