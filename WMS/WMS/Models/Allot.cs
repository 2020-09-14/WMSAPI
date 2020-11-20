using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WMS.Models
{
    public class Allot                                //调拨单列表
    {
        [Key]
        public int AId { get; set; }                  //序号
        [Required]
        public string ARequisition { get; set; }      //调拨单号
        [Required]
        public string ACallout { get; set; }          //调出仓库
        [Required]
        public string AFold { get; set; }             //调入仓库
        [Required]
        public string APerson { get; set; }           //调拨人
        [Required]
        public DateTime ADate { get; set; }           //调拨日期
        [Required]
        public int AAuditstatus { get; set; }         //审核状态
        [Required]
        public int AAllocatingstate { get; set; }     //调拨状态
        [Required]
        public int APackingquantity { get; set; }     //装框数量
        [Required]
        public int AWId { get; set; }                 //外键
    }
}
