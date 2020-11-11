using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WMS.Models
{
    public class Godown
    {
        [Key]
        public int GodownId { get; set; }
        public int GodownRegisterId { get; set; }
    
    }
    
}
