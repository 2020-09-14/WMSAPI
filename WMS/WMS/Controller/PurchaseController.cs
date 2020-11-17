using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using WMS.Dtos;
using WMS.Helper;
using WMS.Models;
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
        public PageHelper GetPurchaseShow(string aaa, string bbb, string times, int pageIndex = 1, int pageSize = 3)
        {
            var PurchaseFromDto = _wMS.GetPurchases();
          
         
            var PurchaseDto = _mapper.Map<IEnumerable<PurchaseShowDto>>(PurchaseFromDto);

            if (!string.IsNullOrWhiteSpace(aaa))
            {
                aaa = aaa.Trim();
                PurchaseDto = PurchaseDto.Where(st => st.PurchaseNum == (aaa));
            }
            if (!string.IsNullOrWhiteSpace(bbb))
            {
                bbb = bbb.Trim();
                PurchaseDto = PurchaseDto.Where(st => st.SupplierName == (aaa));
            }
            
            if (!string.IsNullOrWhiteSpace(times) || times=="null")
            {
                
                var sz = times.Split(",");
                string ba = sz[0].Replace(" GMT 0800 (中国标准时间)", "");
                string begin = Convert.ToDateTime(ba).ToString("yyyy-MM-dd");
                string oa = sz[1].Replace(" GMT 0800 (中国标准时间)", "");
                string over = Convert.ToDateTime(oa).ToString("yyyy-MM-dd");
               

                PurchaseDto = PurchaseDto.Where(t => t.PurchaseTime > Convert.ToDateTime(begin) && t.PurchaseTime < Convert.ToDateTime(over)).ToList();
           
            }
            int count = PurchaseDto.Count();
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
            pd.Purchase_list = PurchaseDto.OrderBy(x => x.PurchaseId).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
            return pd;
        }
        [Route("/api/showsId")]
        [HttpGet]
        public IActionResult GetPurchaseShowId(int id)
        {
            var PurchaseFromDto = _wMS.GetPurchases();
            if (id>0)
            {
                PurchaseFromDto = PurchaseFromDto.Where(s => s.PurchaseId == id);
            }
            if (PurchaseFromDto == null || PurchaseFromDto.Count() <= 0)
            {
                return NotFound("没有数据！！！");
            }
            var PurchaseDto = _mapper.Map<IEnumerable<PurchaseShowDto>>(PurchaseFromDto);

           
            return Ok(PurchaseDto);
        }
        [Route("/api/showsupplier")]
        [HttpGet]
        public IActionResult Getshowsupplier()
        {
            var supplierFromDto = _wMS.GetEnumerablesupplier();
            if (supplierFromDto == null || supplierFromDto.Count()<= 0)
            {
                return NotFound("没有数据！！！");
            }
            var supplierDto = _mapper.Map<IEnumerable<EX_supplierShowDto>>(supplierFromDto);
            return Ok(supplierDto);
        }
        [Route("/api/showex_goodstwo")]
        [HttpGet]
        public IActionResult Getshowex_goodstwo()
        {
            //var rand = (DateTime.Now).ToString("yyyyMMdd");
            //for (int i = 0; i < 1; i++)
            //{
            //    Random rd = new Random();
            //    rand += rd.Next().ToString();
            //}
            var ex_goodstwoFromDto = _wMS.GetEx_GoodsTWO();
            if (ex_goodstwoFromDto == null || ex_goodstwoFromDto.Count() <= 0)
            {
                return NotFound("没有数据！！！");
            }
            var ex_goodstwoDto = _mapper.Map<IEnumerable<Ex_GoodsTWODto>>(ex_goodstwoFromDto);
            return Ok(ex_goodstwoDto);
        }
        [Route("/api/AddPurchae")]
        [HttpPost]
        public IActionResult AddPurchase(CreatePurchaseDto createPurchaseDto)
        {
            var rand = (DateTime.Now).ToString("yyyyMMdd");
            for (int i = 0; i < 1; i++)
            {
                Random rd = new Random();
                rand += rd.Next().ToString();
            }
            createPurchaseDto.PurchaseNum = rand;
            createPurchaseDto.PurchaseTime = DateTime.Now;
            createPurchaseDto.PurchaseName = "王朝";
            createPurchaseDto.PurchaseState = 0;
            var purchaseModel = _mapper.Map<Purchase>(createPurchaseDto);
            _wMS.AddPurchase(purchaseModel);
            _wMS.Save();
            return Ok(1);
        }

    }
}



