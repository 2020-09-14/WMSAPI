using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WMS.Models
{
    public class Details                                     //补货列表+补货详情表
    {
        [Key]
        public int DId { get; set; }                        //序号
        [Required]
        public string DRepairinvoice { get; set; }          //补货单
        [Required]
        public DateTime DDate { get; set; }                 //补货日期
        [Required]
        public string DClassify { get; set; }               //一级分类
        [Required]
        public string DName { get; set; }                   //商品名称
        [Required]
        public string DCoding { get; set; }                 //商品编码
        [Required]
        public string DSpecification { get; set; }          //规格
        [Required]
        public decimal DPrice { get; set; }                 //价格
        [Required]
        public int DAmount { get; set; }                    //数量
        [Required]
        public int DAvailable { get; set; }                 //可用库存
        [Required]
        public string DTotal { get; set; }                  //合计补货
        [Required]
        public int DAudit { get; set; }                     //审核
        [Required]
        public int DTotalNum { get; set; }                  //审核合计数量
        [Required]
        public int DComparison { get; set; }                //对比需求
        [Required]
        public int DClose { get; set; }                     //关闭补货需求
        [Required]
        public int DWId { get; set; }                       //外键
    }
}
