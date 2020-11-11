using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WMS.Models
{
    public class AOGregister
    {
        [Key]
        public int AOGId { get; set; }
        public int AOGPurchase { get; set; }
        public int AOGState { get; set; }
        public int AOGNum { get; set; }
        public int AOGWarehouse { get; set; }
        public string AOGRemark { get; set; }
     
    }
}
