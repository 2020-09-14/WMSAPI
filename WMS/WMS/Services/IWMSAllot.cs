using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WMS.List;
using WMS.Models;

namespace WMS.Services
{
    public interface IWMSAllot
    {
        IEnumerable<Allot> GetShowAllot();                    //显示调拨列表
        IEnumerable<Itemdetails_List> GetItemdetails();       //显示调拨详情信息
        IEnumerable<EDispose> GetEDisposes();
        IEnumerable<SendTheShipping> GetSendTheShippings();

        IEnumerable<BStorage> GetBStorages();                //显示调拨入库
        IEnumerable<Notarize> Notarizes();                   //入库确定显示
        IEnumerable<Details_List> GetShowDetails();          //显示补货详情

        
       

        IEnumerable<Itemdetails_List> GetItemdetailsSH();    //审核
        IEnumerable<Itemdetails_List> GetItemdetailsCK();    //查看
        //IEnumerable<Allot> DelAllot();                       //单删调拨列表
        IEnumerable<Details_List> GetShowBH();                 //显示补货编号
        IEnumerable<SendTheShipping_List> GetShowSendTheShipping();  //显示配送区
        
    }
}
