using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WMS.Models
{
    public class Ex_GoodsThr
    {
        //单个商品
        [Key]
        public int GoodsThId { get; set; }
        [MaxLength(200)]
        [Required]
        public int GTname { get; set; }
        [MaxLength(200)]
        [Required]
        public int Specification { get; set; }

        [MaxLength(200)]
        public string Coding { get; set; }

        public int State { get; set; }
        public int TWOIdd { get; set; }
    }
}
