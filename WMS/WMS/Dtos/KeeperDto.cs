using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WMS.Dtos
{
    public class KeeperDto
    {
        //库管员表
        public int WareHouserKeeperId { get; set; }
        public string KeeperName { get; set; }//姓名
        public string KeeperPhone { get; set; }//手机号
        public DateTime CreateTime { get; set; }//创建时间
        public int State { get; set; }//状态
        public int WId { get; set; }//仓库外键
    }
}
