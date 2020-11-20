using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WMS.Dtos
{
    public class NotarizeShowDto
    {
        
        public int NId { get; set; }                       //序号
        
        public string NCoding { get; set; }                //单据编码
       
        public string NOdd { get; set; }                   //调拨入库单号
   
        public string NOutlet { get; set; }                //调出门店
     
        public string NWarm { get; set; }                  //温区
  
        public string NSCoding { get; set; }               //商品编码
 
        public string NName { get; set; }                  //商品名称

        public string NSpecification { get; set; }         //规格
     
        public int NQuantity { get; set; }                 //数量
  
        public string NPerson { get; set; }                //处理人

        public DateTime NDate { get; set; }                //处理日期

        public int NState { get; set; }                    //状态

        public int NWId { get; set; }                      //外键
    }
}
