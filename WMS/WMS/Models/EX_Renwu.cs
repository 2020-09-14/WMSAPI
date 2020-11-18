using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WMS.Models
{
    public class EX_Renwu
    {
        [Key]
        public int ShipmentId { get; set; }
        [MaxLength(200)]
        public string ShCoding { get; set; }
        public DateTime Createtime { get; set; }
        public int State { get; set; }
        public int Goodsidd { get; set; }
        [MaxLength(200)]
        public string Cause { get; set; }
        [MaxLength(200)]
        public string article { get; set; }
        public int Shsum { get; set; }
    }
}
