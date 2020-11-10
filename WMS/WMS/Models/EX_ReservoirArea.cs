using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WMS.Models
{
    public class EX_ReservoirArea
    {
        //库区
        [Key]
        public int ReservoirAreaId { get; set; }
        [MaxLength(200)]
        public string Rname { get; set; }
        [MaxLength(200)]
        public string Remark { get; set; }
        [MaxLength(200)]
        public string TemperatureZone { get; set; }

        public int WIdd { get; set; }

    }
}

