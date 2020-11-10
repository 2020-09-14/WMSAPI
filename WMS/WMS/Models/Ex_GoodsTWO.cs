using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WMS.Models
{
    public class Ex_GoodsTWO
    {
        //二级的商品
        [Key]
        public int Ex_GoodsTWOId { get; set; }

        [MaxLength(200)]
        [Required]
        public string GWname { get; set; }

        [MaxLength(200)]
        [Required]
        public string Specification { get; set; }

        public int OneIdd { get; set; }

        [MaxLength(200)]
        [Required]
        public string Coding { get; set; }

        public int TWOsum { get; set; }

        public int EX_ZhyId { get; set; }
    }
}
