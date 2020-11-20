using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WMS.Models
{
    public class Notarize                                  //入库确定表
    {                     
        [Key]
        public int NId { get; set; }                       //序号
        [Required]
        public string NCoding { get; set; }                //单据编码
        [Required]
        public string NOdd { get; set; }                   //调拨入库单号
        [Required]
        public string NOutlet { get; set; }                //调出门店
        [Required]
        public string NWarm { get; set; }                  //温区
        [Required]
        public string NSCoding { get; set; }               //商品编码
        [Required]
        public string NName { get; set; }                  //商品名称
        [Required]
        public string NSpecification { get; set; }         //规格
        [Required]
        public int NQuantity { get; set; }                 //数量
        [Required]
        public string NPerson { get; set; }                //处理人
        [Required]
        public DateTime NDate { get; set; }                //处理日期
        [Required]
        public int NState { get; set; }                    //状态
        [Required]
        public int NWId { get; set; }                      //外键
    }
}
