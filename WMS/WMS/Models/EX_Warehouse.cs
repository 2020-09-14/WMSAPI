using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WMS.Models
{
    public class EX_Warehouse
    {
        //主仓库
        [Key]
        public int WarehouseId { get; set; }
        [MaxLength(200)]
        [Required]
        public string Wname { get; set; }
        [MaxLength(200)]
        [Required]
        public string Address { get; set; }
    }
}
