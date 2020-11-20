using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WMS.List
{
    [NotMapped]
    public class Itemdetails_List
    {
        public int IId { get; set; }                    //序号

        public string IItemcode { get; set; }           //物品编码

        public string IName { get; set; }               //物品名称

        public int IInventory { get; set; }             //可用库存

        public int IApply { get; set; }                 //申请数量

        public int IExamine { get; set; }               //审批数量

        public int IHaveoutbound { get; set; }          //已出库数量

        public string IUnits { get; set; }              //计量单位

        public decimal IPrice { get; set; }             //单价

        public string IPicture { get; set; }            //图片

        public int IWId { get; set; }                   //外键

        public int ISum { get; set; }                   //待审核调拨总数

        public decimal IMoney { get; set; }             //审核金额

        public string Conding { get; set; }             //商品编码

        public string Gname { get; set; }               //商品名称

        public int InventorySettings { get; set; }      //库存上限
    }
}
