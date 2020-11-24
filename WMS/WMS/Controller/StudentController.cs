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
        [Route("/api/show")]
        [HttpGet]
        public async Task<IActionResult> GetShow()
        {
            var studentFromDto = await _wMS.GetStudents();
            if (studentFromDto == null || studentFromDto.Count() <= 0)
            {
                return NotFound("没有数据！！！");
            }
            var studentDto = _mapper.Map<IEnumerable<StudentDto>>(studentFromDto);
            return Ok(studentDto);
        }
    }
}
