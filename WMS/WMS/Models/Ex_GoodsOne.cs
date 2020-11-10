using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WMS.Models
{
    public class Ex_GoodsOne
    {
        //到货商品
        [Key]
        public int Ex_GoodsOneId { get; set; }

        [MaxLength(200)]
        [Required]
        public string GOname { get; set; }

        [MaxLength(200)]
        [Required]
        public string Coding { get; set; }

        public int ONEsum { get; set; } 

        public int Pidd { get; set; }

        [MaxLength(200)]
        [Required]
        public int Supplier { get; set; }

        public int State { get; set; }

        public DateTime Createtime { get; set; }

        [MaxLength(200)]
        [Required]
        public string PurchasePerson { get; set; }
    }
}
