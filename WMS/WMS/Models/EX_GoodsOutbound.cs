using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WMS.Models
{
    public class EX_GoodsOutbound
    {
        [Key]
        public int GoodsOId { get; set; }

        [MaxLength(200)]
        [Required]
        public string GoCoding { get; set; }
        public int Gosum { get; set; }
        public string GoName { get; set; }
        [MaxLength(200)]
        [Required]
        public string GoSpecification { get; set; }
        public int RenIdd { get; set; }
    }
}
