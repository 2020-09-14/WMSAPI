using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WMS.Dtos
{
    public class BStorageShowDto
    {
        
        public int BId { get; set; }                       //行号
        
        public string BEntry { get; set; }                 //调拨入库单号
        
        public string BTS { get; set; }                    //TS调入单号
        
        public string BWarehouse { get; set; }             //调出仓库
        
        public string BFold { get; set; }                  //调入仓库
        
        public DateTime BSend { get; set; }                //发送日期
        
        public DateTime BEnter { get; set; }               //入库日期
        
        public string BWarm { get; set; }                  //温区
        
        public int BSum { get; set; }                      //商品总数
        
        public string BPerson { get; set; }                //调拨人
        
        public string BConsignee { get; set; }             //收货人
        
        public int BWId { get; set; }                      //外键
    }
}
