using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WMS.Dtos;
using WMS.List;
using WMS.Models;

namespace WMS.Services
{
  public  interface EX_Wangchao
    {
        IEnumerable<EX_Shipment_list> EX_Shipments();
        //商品品类
        IEnumerable<EX_ProductCategory> EX_ProductCategories();
        IEnumerable<EX_Renwu> EX_Renwus();
        IEnumerable<EX_Renwu> EX_Renwus(EX_Renwu eX_Renwu);
        IEnumerable<Ex_GoodsTWO> Ex_GoodsTWOs();
        int Ex_AddChukuwupin(List<EX_GoodsOutbound> list,string ids);
        bool Save();
        IEnumerable<EX_GoodsOutbound> EX_GoodsOutboundsShow();//显示相对于的商品\
        //所有日报表
        IEnumerable<DailyStatement> DailyStatements();
        //查询
        IEnumerable<EX_RenwusList> EX_Renwus(string time);
    }
}
