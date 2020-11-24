using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WMS.Models
{
    public class ProWareHouse//商品品类 仓库 二级商品 关联表
    {
        [Key]
        public int PId { get; set; }
        public int ProductCategoryId { get; set; }
        public int WarehouseId { get; set; }
        public int Ex_GoodsTWOId { get; set; }
    }
}
