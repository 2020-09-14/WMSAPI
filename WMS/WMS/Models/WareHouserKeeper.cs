using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WMS.Models
{
    public class WareHouserKeeper
    {
        //库管员表
        [Key]
        public int WareHouserKeeperId { get; set; }
        [MaxLength(200)]
        [Required]
        public string KeeperName { get; set; }//姓名
        [MaxLength(200)]
        [Required]
        public string KeeperPhone { get; set; }//手机号
        public DateTime CreateTime { get; set; }//创建时间
        public int State { get; set; }//状态
        public int WId { get; set; }//仓库外键
    }
}
