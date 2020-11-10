using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WMS.Models
{
    public class EX_Zhy
    {
        //货位
        [Key]
        public int ZhyId { get; set; }
        [MaxLength(200)]
        public string Zname { get; set; }
        [MaxLength(200)]
        public string TemperatureZone { get; set; }
        public int Ridd { get; set; }
        public int InventorySettings { get; set; }
    }
}
