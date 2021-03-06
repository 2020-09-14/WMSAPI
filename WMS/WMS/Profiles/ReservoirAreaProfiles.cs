﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WMS.Dtos;
using WMS.List;
using WMS.Models;

namespace WMS.Profiles
{
    public class ReservoirAreaProfiles:Profile
    {
        public ReservoirAreaProfiles()
        {
            CreateMap<ReservoirArea_list,ReservoirAreaDto>();
            CreateMap<CreateReservoirAreaDto, EX_ReservoirArea>();
            CreateMap<EX_ReservoirArea, EX_ReservoirAreaDto>();
        }
    }
}
