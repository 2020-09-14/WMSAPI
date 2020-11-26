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
    public class GoodsAllocationProfiles : Profile
    {
        public GoodsAllocationProfiles()
        {
            CreateMap<WRZ_list, GoodsAllocationDto>();
            CreateMap<CreateGoodsAllocationDto, EX_Zhy>();
        }
    }
}
