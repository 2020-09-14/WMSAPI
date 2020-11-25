using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WMS.Dtos;
using WMS.Models;
using WMS.Services;
using WMS.List;
namespace WMS.Profiles
{
    public class PurchaseProfile :Profile
    {
        public PurchaseProfile()
        {
            CreateMap<Purchase, PurchaseShowDto>();
            CreateMap<Purchase_list, PurchaseShowDto>();

            CreateMap<Goods, GoodsDto>();


            CreateMap<EX_Shipment_list, EX_ShipmentDto>();
            CreateMap<GodownTodoId_list, GodownTodoIdDto>();
            CreateMap<EX_ProductCategory, EX_ProductCategoryDto>();
            CreateMap<EX_Renwu, EX_RenwusDto>();
            CreateMap<Ex_GoodsTWO, Ex_GoodsTWODto>();
            

            CreateMap<EX_supplier, EX_supplierShowDto>();
            CreateMap<Ex_GoodsTWO, Ex_GoodsTWODto>();
            CreateMap<CreatePurchaseDto, Purchase>();
            CreateMap<DailyStatementDto, DailyStatement>();
            CreateMap<EX_RenwusList, EX_rbao>();


        }
    }
}
