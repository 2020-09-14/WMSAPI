using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WMS.Dtos;
using WMS.Services;

namespace WMS.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchaseController :ControllerBase
    {
        private IWMSPurchaseRepository _wMS;
        private IMapper _mapper;
        public PurchaseController(IWMSPurchaseRepository wMS, IMapper mapper)
        {
            _wMS = wMS;
            _mapper = mapper;
        }
        [Route("/api/shows")]
        [HttpGet]
        public IActionResult GetPurchaseShow()
        {
            var PurchaseFromDto = _wMS.GetPurchases();
            if (PurchaseFromDto == null || PurchaseFromDto.Count() <= 0)
            {
                return NotFound("没有数据！！！");
            }
            var PurchaseDto = _mapper.Map<IEnumerable<PurchaseShowDto>>(PurchaseFromDto);
            return Ok(PurchaseDto);
        }
    }
}
