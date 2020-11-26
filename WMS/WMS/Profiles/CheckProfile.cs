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
    public class CheckProfile:Profile
    {
        public CheckProfile()
        {
            CreateMap<Check, CheckDto>();

            CreateMap<check_list,CheckDto>();

            CreateMap<CreateCheckDto, Check>();

        }
    }
}
