﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WMS.Models
{
    public class Details                                     //补货列表+补货详情表
    {
        [Key]
        public int DId { get; set; }                        //序号

        public string DRepairinvoice { get; set; }          //补货单

        public DateTime DDate { get; set; }                 //补货日期

        public string DClassify { get; set; }               //一级分类

        public string DName { get; set; }                   //商品名称

        public string DCoding { get; set; }                 //商品编码

        public string DSpecification { get; set; }          //规格

        public decimal DPrice { get; set; }                 //价格

        public int DAmount { get; set; }                    //数量

        public int DAvailable { get; set; }                 //可用库存

        public string DTotal { get; set; }                  //合计补货

        public int DAudit { get; set; }                     //审核

        public int DTotalNum { get; set; }                  //审核合计数量

        public int DComparison { get; set; }                //对比需求

        public int DClose { get; set; }                     //关闭补货需求

        public int DWId { get; set; }                       //外键
    }
}
