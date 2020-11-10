using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WMS.Models
{
    public class Goods
    {
        //商品
        [Key]
        public int GoodsId { get; set; }
        [MaxLength(200)]
        [Required]
        public int Conding { get; set; }

        public int InventorySettings { get; set; }

        [MaxLength(200)]
        public string Gname { get; set; }

        public int level { get; set; }
    }
}
