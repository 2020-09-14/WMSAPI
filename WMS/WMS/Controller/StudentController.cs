using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WMS.Dtos;
using WMS.Models;
using WMS.Services;

namespace WMS.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private IWMSRepository _wMS;
        private IMapper _mapper;
        public StudentController(IWMSRepository wMS, IMapper mapper)
        {
            _wMS = wMS;
            _mapper = mapper;
        }
 
        
    }
}
