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
        }
    }
}
