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
using WMS.Helper;
using System.Runtime.Serialization;
using WMS.List;

namespace WMS.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class CheckController : ControllerBase
    {
        private IWMSCheckRepository _wms;
        private IMapper _mapper;
        public CheckController(IWMSCheckRepository wMS,IMapper mapper)
        {
            _wms = wMS;
            _mapper = mapper;
        
        }
        [Route("/api/Checkshow")]
        [HttpGet]
        public IActionResult GetCheckShow()
        {
            var CheckFromDto = _wms.GetCheck();
            if (CheckFromDto==null||CheckFromDto.Count()<=0)
            {
                return NotFound("无数据");
            }
            var Check = _mapper.Map<IEnumerable<CheckDto>>(CheckFromDto);
            return Ok(Check);
        
        }

        [Route("/api/AddCheck")]
        [HttpPost]
        public IActionResult AddCheck([FromBody]CreateCheckDto checkDto)
        {
            var Check = _mapper.Map<Check>(checkDto);
            var FromDto = _wms.AddChecka(Check);
       
            return Ok(FromDto);

        
        }

        //未完成盘点单
        [Route("/api/CheckshowNo11")]
        [HttpGet]
        public IActionResult GetCheckShowNo(int pageIndex = 1, int pageSize = 3)
        {
            IEnumerable<Check> CheckFromDto = _wms.GetCheckNo();
            var Check = _mapper.Map<IEnumerable<CheckDto>>(CheckFromDto);

            int count = Check.Count();
            int page;
            if (count % pageSize == 0)
            {
                page = count / pageSize;
            }
            else
            {
                page = count / pageSize + 1;
            }
            //判断状态是完成还是未完成
            Check = Check.Where(x => x.CheckStates == 1 || x.CheckStates == 2).ToList();

            PageHelper pd = new PageHelper();
            pd.pageSize = pageSize;
            pd.pageIndex = pageIndex;
            pd.totalCount = count;
            pd.CheckDtos = Check.OrderBy(x => x.CheckTaskId).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
            return Ok(pd);
        }

        //已完成
        [Route("/api/CheckshowYes11")]
        [HttpGet]
        public IActionResult GetCheckShowYes(string CheckCNo, string CheckName, string DefaultInventoryPeople, int pageIndex = 1, int pageSize = 3)
        {
            IEnumerable<Check>  CheckFromDto = _wms.GetCheckYes();
            var Check = _mapper.Map<IEnumerable<CheckDto>>(CheckFromDto);
            if (!string.IsNullOrWhiteSpace(CheckCNo))
            {
                CheckCNo = CheckCNo.Trim();
                Check = Check.Where(s => s.CheckCNo == (CheckCNo));
            }

            if (!string.IsNullOrWhiteSpace(CheckName))
            {
                CheckName = CheckName.Trim();
                Check = Check.Where(s => s.CheckName == (CheckName));
            }

            if (!string.IsNullOrWhiteSpace(DefaultInventoryPeople))
            {
                DefaultInventoryPeople = DefaultInventoryPeople.Trim();
                Check = Check.Where(s => s.DefaultInventoryPeople == (DefaultInventoryPeople));
            }

            int count = Check.Count();
            int page;
            if (count % pageSize == 0)
            {
                page = count / pageSize;
            }
            else
            {
                page = count / pageSize + 1;
            }
            //判断状态是完成还是未完成
            Check = Check.Where(x => x.CheckStates == 3 || x.CheckStates == 4).ToList();

            PageHelper pd = new PageHelper();
            pd.pageSize = pageSize;
            pd.pageIndex = pageIndex;
            pd.totalCount = count;
            pd.CheckDtos = Check.OrderBy(x => x.CheckTaskId).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
            return Ok(pd);
        }

        //实盘显示
        [Route("/api/CheckshowShi11")]
        [HttpGet]
        public IActionResult GetCheckShowShi(int pageIndex = 1, int pageSize = 3)
        {
            var CheckFromDto = _wms.CheckShi();
            var Check = _mapper.Map<IEnumerable<CheckDto>>(CheckFromDto);

            int count = Check.Count();
            int page;
            if (count % pageSize == 0)
            {
                page = count / pageSize;
            }
            else
            {
                page = count / pageSize + 1;
            }


            PageHelper pd = new PageHelper();
            pd.pageSize = pageSize;
            pd.pageIndex = pageIndex;
            pd.totalCount = count;
            pd.CheckDtos = Check.OrderBy(x => x.CheckTaskId).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
            return Ok(pd);
        }

        //审核调整
        [Route("/api/CheckshowShen")]
        [HttpGet]
        public IActionResult GetCheckShowShen(int pageIndex = 1, int pageSize = 3)
        {
            var CheckFromDto = _wms.GetCheckShen();
            var Check = _mapper.Map<IEnumerable<CheckDto>>(CheckFromDto);

            int count = Check.Count();
            int page;
            if (count % pageSize == 0)
            {
                page = count / pageSize;
            }
            else
            {
                page = count / pageSize + 1;
            }


            PageHelper pd = new PageHelper();
            pd.pageSize = pageSize;
            pd.pageIndex = pageIndex;
            pd.totalCount = count;
            pd.CheckDtos = Check.OrderBy(x => x.CheckTaskId).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
            return Ok(pd);
        }







    }
}
