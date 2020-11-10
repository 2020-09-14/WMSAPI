using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WMS.Models
{
    public class DailyStatement
    {
        //商品订单出库数据表
        [Key]
        public int DailyStatementId { get; set; }
        [MaxLength(200)]
        public string Pname { get; set; }
    }
}
