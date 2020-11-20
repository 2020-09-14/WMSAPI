using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WMS.Models
{
    public class EDispose                                    //调入处理
    {
        [Key]
        public int EId { get; set; }                          //行号
        [Required]
        public string EEntry { get; set; }                    //调拨入库单号
        [Required]
        public string EWarehouse { get; set; }                //调入仓库  
        [Required]
        public DateTime EEnter { get; set; }                  //入库日期
        [Required]
        public string EConsignee { get; set; }                //收货人
        [Required]
        public string EWarm { get; set; }                     //温区
        [Required]
        public string ECategory { get; set; }                 //商品品类
        [Required]
        public string ECoding { get; set; }                   //商品编码
        [Required]
        public string EName { get; set; }                     //商品名称
        [Required]
        public string ESpectification { get; set; }           //规格
        [Required]
        public string EUnit { get; set; }                     //单位
        [Required]
        public string EBatch { get; set; }                    //批次
        [Required]
        public string EAllocation { get; set; }               //货位
        [Required]
        public int EQuantity { get; set; }                    //数量
        [Required]
        public int EDisposer { get; set; }                    //处理数量
        [Required]
        public int EWId { get; set; }                         //外键
    }
}
