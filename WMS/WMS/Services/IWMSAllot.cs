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
        IEnumerable<BStorage> GetBStorages();
        IEnumerable<Notarize> Notarizes();
        IEnumerable<Details_List> GetShowDetails();          //显示补货
        IEnumerable<Itemdetails_List> GetItemdetailsSH();    //审核
        IEnumerable<Itemdetails_List> GetItemdetailsCK();    //查看
    }
}
