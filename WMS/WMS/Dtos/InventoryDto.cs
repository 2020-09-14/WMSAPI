using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WMS.Dtos
{
    public class InventoryDto
    {
        public int ProductCategoryId { get; set; }
        public int Pidd { get; set; }
        public string ProductName { get; set; }//品类名称

        //主仓库
        public int WarehouseId { get; set; }
        public string Wname { get; set; }//仓库名
        public string Address { get; set; }//仓库地址

        //二级的商品
        public int Ex_GoodsTWOId { get; set; }
        public string GWname { get; set; }//商品名称
        public string Specification { get; set; }//规格
        public int OneIdd { get; set; }
        public string Coding { get; set; }//编码
        public int TWOsum { get; set; }//总数量
        public int EX_ZhyId { get; set; }


    }
}
