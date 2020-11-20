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
    public class AllotProfile:Profile
    {
        public AllotProfile()
        {
            CreateMap<Allot, AllotShowDto>();
            CreateMap<Itemdetails_List, ItemdetailsShowDto>();
            CreateMap<EDispose, EDisposeShowDto>();
            CreateMap<SendTheShipping, SendTheShippingShowDto>();
            CreateMap<BStorage, BStorageShowDto>();
            CreateMap<Notarize, NotarizeShowDto>();
            CreateMap<Details_List, DetailsShowDto>();
        }
    }
}
