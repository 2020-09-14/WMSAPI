using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WMS.Dtos;
using WMS.List;
using WMS.Models;

namespace WMS.Profiles
{
    public class InventoryProfiles:Profile
    {
        public InventoryProfiles()
        {
            CreateMap<Inventory_List, InventoryDto>();
            CreateMap<EX_Warehouse, EX_WarehouseDto>();
            CreateMap<EX_ProductCategory, EX_ProductCategoryDto>();
            CreateMap<CreateWareHouseDto, EX_Warehouse>();
        }
    }
}
