using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using WMS.Dtos;
using WMS.Helper;
using WMS.Services;

namespace WMS.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class AllotController : ControllerBase
    {
        private IWMSAllot _wMS;
        private IMapper _mapper;
        public AllotController(IWMSAllot wMS, IMapper mapper)
        {
            _wMS = wMS;
            _mapper = mapper;
        }
        [Route("/api/AllotShow")]
        [HttpGet]
        public IActionResult AllotShow(int pageIndex=1,int pageSize=3)
        {
            var AllotFromDto = _wMS.GetShowAllot();
            var AllotDto = _mapper.Map<IEnumerable<AllotShowDto>>(AllotFromDto);
            int count = AllotDto.Count();
            int page;
            if (count%pageSize==0)
            {
                page = count / pageSize;
            }
            else
            {
                page = count / pageSize + 1;
            }
            Allot_listHelper pd = new Allot_listHelper();
            pd.pageSize = pageSize;
            pd.pageIndex = pageIndex;
            pd.totalCount = count;
            pd.Allot_list = AllotDto.OrderBy(x => x.AId).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
            return Ok(pd);
        }
        [Route("/api/ItemdetailShow")]
        [HttpGet]
        public IActionResult ItemdetailShow(int pageIndex = 1, int pageSize = 3)
        {
            var ItemdetailsFromDto = _wMS.GetItemdetails();
            int count = ItemdetailsFromDto.Count();
            int page;
            if (count % pageSize == 0)
            {
                page = count / pageSize;
            }
            else
            {
                page = count / pageSize + 1;
            }
            ItemdetailsShowHelper pd = new ItemdetailsShowHelper();
            pd.pageSize = pageSize;
            pd.pageIndex = pageIndex;
            pd.totalCount = count;
            pd.Itemdetails_list = ItemdetailsFromDto.OrderBy(x => x.IId).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
            return Ok(pd);
        }
        [Route("/api/EDisposeShow")]
        [HttpGet]
        public IActionResult EDisposeShow()
        {
            var EDisposeFromDto = _wMS.GetEDisposes();
            if (EDisposeFromDto == null || EDisposeFromDto.Count() < 0)
            {
                return NotFound("没有数据！！！");
            }
            var ItemdetailsDto = _mapper.Map<IEnumerable<EDisposeShowDto>>(EDisposeFromDto);
            return Ok(ItemdetailsDto);
        }
        [Route("/api/SendTheShippingShow")]
        [HttpGet]
        public IActionResult SendTheShippingShow()
        {
            var SendTheShippingFromDto = _wMS.GetSendTheShippings();
            if (SendTheShippingFromDto == null || SendTheShippingFromDto.Count() < 0)
            {
                return NotFound("没有数据！！！");
            }
            var SendTheShippingDto = _mapper.Map<IEnumerable<SendTheShippingShowDto>>(SendTheShippingFromDto);
            return Ok(SendTheShippingDto);
        }
        [Route("/api/BStorageShow")]
        [HttpGet]
        public IActionResult BStorageShow()
        {
            var BStorageFromDto = _wMS.GetBStorages();
            if (BStorageFromDto == null || BStorageFromDto.Count() < 0)
            {
                return NotFound("没有数据！！！");
            }
            var BStorageDto = _mapper.Map<IEnumerable<BStorageShowDto>>(BStorageFromDto);
            return Ok(BStorageDto);
        }
        [Route("/api/NotarizeShow")]
        [HttpGet]
        public IActionResult NotarizeShow()
        {
            var NotarizeFromDto = _wMS.Notarizes();
            if (NotarizeFromDto == null || NotarizeFromDto.Count() < 0)
            {
                return NotFound("没有数据！！！");
            }
            var NotarizeDto = _mapper.Map<IEnumerable<NotarizeShowDto>>(NotarizeFromDto);
            return Ok(NotarizeDto);
        }
        [Route("/api/DetailsShow")]
        [HttpGet]
        public IActionResult DetailsShow(int pageIndex = 1, int pageSize = 3)
        {
            var DetailsFromDto = _wMS.GetShowDetails();
            var DetailsDto = _mapper.Map<IEnumerable<DetailsShowDto>>(DetailsFromDto);
            int count = DetailsDto.Count();
            int page;
            if (count % pageSize == 0)
            {
                page = count / pageSize;
            }
            else
            {
                page = count / pageSize + 1;
            }
            DetailsShowHelper pd = new DetailsShowHelper();
            pd.pageSize = pageSize;
            pd.pageIndex = pageIndex;
            pd.totalCount = count;
            pd.Details_List = DetailsFromDto.OrderBy(x => x.DId).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
            return Ok(pd);
        }
        [Route("/api/AuditShow")]
        [HttpGet]
        public IActionResult AuditShow(int pageIndex = 1, int pageSize = 3)
        {
            var AuditShowFromDto = _wMS.GetItemdetailsSH();
            var AuditDto = _mapper.Map<IEnumerable<ItemdetailsShowDto>>(AuditShowFromDto);
            int count = AuditDto.Count();
            int page;
            if (count % pageSize == 0)
            {
                page = count / pageSize;
            }
            else
            {
                page = count / pageSize + 1;
            }
            ItemdetailsShowHelper pd = new ItemdetailsShowHelper();
            pd.pageSize = pageSize;
            pd.pageIndex = pageIndex;
            pd.totalCount = count;
            pd.Itemdetails_list = AuditShowFromDto.OrderBy(x => x.IId).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
            return Ok(pd);
        }
        [Route("/api/LookShow")]
        [HttpGet]
        public IActionResult LookShow(int pageIndex = 1, int pageSize = 3)
        {
            var LookShowFromDto = _wMS.GetItemdetailsCK();
            var LookDto = _mapper.Map<IEnumerable<ItemdetailsShowDto>>(LookShowFromDto);
            int count = LookDto.Count();
            int page;
            if (count % pageSize == 0)
            {
                page = count / pageSize;
            }
            else
            {
                page = count / pageSize + 1;
            }
            ItemdetailsShowHelper pd = new ItemdetailsShowHelper();
            pd.pageSize = pageSize;
            pd.pageIndex = pageIndex;
            pd.totalCount = count;
            pd.Itemdetails_list = LookShowFromDto.OrderBy(x => x.IId).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
            return Ok(pd);
        }
    }
}
