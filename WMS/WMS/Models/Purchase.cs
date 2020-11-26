using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WMS.Models
{
    public class Purchase
    {

        
        //采购单
        [Key]
   
        public int PurchaseId { get; set; }

        [Required]
        [MaxLength(200)]
        public string PurchaseNum { get; set; }
        public int PurchaseSupplierId { get; set; }
        public DateTime PurchaseTime { get; set; }
        [Required]
        [MaxLength(200)]
        public string PurchaseName { get; set; }
        public int PurchaseGoodsId { get; set; }
        public int PurchaseState { get; set; }




    }
}
