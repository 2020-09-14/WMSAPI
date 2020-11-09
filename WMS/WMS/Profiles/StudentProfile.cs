using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WMS.Dtos;
using WMS.Models;

namespace WMS.Profiles
{
    public class StudentProfile :Profile
    {
        public StudentProfile()
        {
            CreateMap<Students, StudentDto>();
        }
    }
}
