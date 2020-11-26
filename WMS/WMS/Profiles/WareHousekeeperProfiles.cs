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
    public class WareHousekeeperProfiles : Profile
    {
        public WareHousekeeperProfiles()
        {
            CreateMap<WareHouseKeeperlist, WareHouseKeeperDto>();
            CreateMap<WareHouserKeeper, KeeperDto>();
            CreateMap<CreateWareHouseKeeperDto, WareHouserKeeper>();
            
        }
    }
}
