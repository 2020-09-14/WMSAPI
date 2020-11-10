using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WMS.Models
{
    public class EX_supplier
    {
        //供应商
        [Key]
        public int SupplierId { get; set; }
        [MaxLength(200)]
        public string SupplierName { get; set; }
        [MaxLength(200)]
        public string Serial { get; set; }
    }
}
