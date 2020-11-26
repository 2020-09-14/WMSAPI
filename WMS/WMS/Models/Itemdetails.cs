using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WMS.Models
{
    public class Itemdetails                            //调拨物品详情
    {
        [Key]
        public int IId { get; set; }                    //序号
        [Required]
        public string IItemcode { get; set; }           //物品编码
        [Required]
        public string IName { get; set; }               //物品名称
        [Required]
        public int IInventory { get; set; }             //可用库存
        [Required]
        public int IApply { get; set; }                 //申请数量
        [Required]
        public int IExamine { get; set; }               //审批数量
        [Required]
        public int IHaveoutbound { get; set; }          //已出库数量
        [Required]
        public string IUnits { get; set; }              //计量单位
        [Required]
        public float IPrice { get; set; }             //单价
        [Required]
        public string IPicture { get; set; }            //图片
        [Required]
        public int IWId { get; set; }                   //外键
        [Required]
        public int ISum { get; set; }                   //待审核调拨总数
        [Required]
        public float IMoney { get; set; }             //审核金额
    }
}
