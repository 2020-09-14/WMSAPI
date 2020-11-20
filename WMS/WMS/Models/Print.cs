using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WMS.Models
{
    public class Print                                    //综合打印
    {                     
        [Key]
        public int PId { get; set; }                      //序号
        [Required]
        public string PCoding { get; set; }               //商品编码
        [Required]
        public string PBatch { get; set; }                //批次号
        [Required]
        public int PCategory { get; set; }                //商品类别
        [Required]
        public string PName { get; set; }                 //商品名称
        [Required]
        public string PSpecification { get; set; }        //规格
        [Required]
        public string PUnit { get; set; }                 //计量单位
        [Required]
        public int PQuantity { get; set; }                //出库数量
        [Required]
        public DateTime PTime { get; set; }               //处理时间
        [Required]
        public string PPerson { get; set; }               //处理人员
        [Required]
        public int PWId { get; set; }                     //外键
    }
}
