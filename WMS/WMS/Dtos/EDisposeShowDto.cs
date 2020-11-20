using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WMS.Dtos
{
    public class EDisposeShowDto
    {
       
        public int EId { get; set; }                          //行号
        
        public string EEntry { get; set; }                    //调拨入库单号
       
        public string EWarehouse { get; set; }                //调入仓库  
        
        public DateTime EEnter { get; set; }                  //入库日期
        
        public string EConsignee { get; set; }                //收货人
        
        public string EWarm { get; set; }                     //温区
        
        public string ECategory { get; set; }                 //商品品类
        
        public string ECoding { get; set; }                   //商品编码
        
        public string EName { get; set; }                     //商品名称
       
        public string ESpectification { get; set; }           //规格
        
        public string EUnit { get; set; }                     //单位
        
        public string EBatch { get; set; }                    //批次
        
        public string EAllocation { get; set; }               //货位
        
        public int EQuantity { get; set; }                    //数量
        
        public int EDisposer { get; set; }                    //处理数量
        
        public int EWId { get; set; }                         //外键
    }
}
