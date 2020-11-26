using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WMS.Dtos
{
    public class CheckDto
    {
        public int CheckTaskId { get; set; }  //盘点任务Id
        public string CheckName { get; set; }   //任务名称
        public string CheckCNo { get; set; }    //盘点单号
        public DateTime CheckTimes { get; set; }     //盘点时间
        public string WareHouseName { get; set; }    //仓库名称
        public string kQName { get; set; }   //库区名称
        public string HjName { get; set; }    //货架名称
        public string DefaultInventoryPeople { get; set; }   //默认盘点人
        public string CheckDetail { get; set; }  //盘点备注
        public int ProductId { get; set; }   //产品表Id
        public int CheckStates { get; set; }   //盘点状态
        public int CheckNumber { get; set; } //盘点序号
        public DateTime TaskTimes { get; set; }  //任务生成时间
        public int CheckNum { get; set; }   //实盘数量
        public string BatchNumber { get; set; }  //批次号
        public DateTime TermOfValidity { get; set; }  //有效期至
        public string GoodsAllocation { get; set; }  //货位
        public int GoodsIds { get; set; }  //关联的商品表外键
        public int GoodsTWOIds { get; set; }  //关联的二级商品表外键

        public int ProductCategoryIds { get; set; }  //关联的品类表外键


        public int Ex_GoodsTWOId { get; set; }


        public string GWname { get; set; }


        public string Specification { get; set; }


        public int OneIdd { get; set; }

        public string Coding { get; set; }

        public int TWOsum { get; set; }

        public int EX_ZhyId { get; set; }
    }
}
