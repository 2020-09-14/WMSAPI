using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WMS.Models
{
    public class EX_ProductCategory
    {
        //商品品类表
        [Key]
        public int ProductCategoryId { get; set; }
        
        public int Pidd { get; set; }
        [MaxLength(200)]
        [Required]
        public string ProductName { get; set; }

    }
}
