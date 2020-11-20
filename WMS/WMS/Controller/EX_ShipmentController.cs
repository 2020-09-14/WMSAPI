using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WMS.Dtos;
using WMS.List;
using WMS.Services;
using Newtonsoft.Json;
using WMS.Models;
using WMS.Helper;
namespace WMS.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class EX_ShipmentController : ControllerBase
    {
        private EX_Wangchao _wMS;
        private IMapper _mapper;
        public EX_ShipmentController(EX_Wangchao wMS, IMapper mapper)
        {
            _wMS = wMS;
            _mapper = mapper;
        }
        [Route("/api/ExShow")]
        [HttpGet]
        public IActionResult GetPurchaseShow()
        {
            var PurchaseFromDto = _wMS.EX_Shipments();
            if (PurchaseFromDto == null || PurchaseFromDto.Count() <= 0)
            {
                return NotFound("没有数据！！！");
            }
            var PurchaseDto = _mapper.Map<IEnumerable<EX_ShipmentDto>>(PurchaseFromDto);
            return Ok(PurchaseDto);
        }
        //树形商品品类
        [Route("/api/Exur")]
        [HttpGet]
        public IActionResult Three(string ids)
        {
            var PurchaseFromDto = _wMS.EX_ProductCategories();
            var aa = _mapper.Map<IEnumerable<EX_ProductCategoryDto>>(PurchaseFromDto);
            if (!string.IsNullOrEmpty(ids))
            {
                aa = aa.Where(s => s.Pidd == Convert.ToInt32(ids));
            }
            return Ok(aa);

        }
        //添加出库任务和商品
        [Route("/api/Ceshi")]
        [HttpPost]
        public IActionResult AddChuku([FromBody]List<Dictionary<string, string>> list)
        {
            
            List<EX_GoodsOutbound> list1 = new List<EX_GoodsOutbound>();
            
            EX_Renwu eX_Renwus = new EX_Renwu();
            eX_Renwus.article = " ";
  
            foreach (var item in list)
            {
                EX_GoodsOutbound aa = new EX_GoodsOutbound();
                foreach (var i in item)
                {
                    if (i.Key == "coding")
                    {
                        aa.GoCoding = i.Value.Trim();
                    }
                    if (i.Key == "gWname")
                    {
                        aa.GoName = i.Value.Trim();
                        if (eX_Renwus.article.Length < 30)
                        {
                            eX_Renwus.article += aa.GoName;
                        }

                    }
                    if (i.Key == "twOsum")
                    {
                        aa.Gosum = Convert.ToInt32(i.Value.Trim());
                        if (eX_Renwus.article.Length < 30)
                        {
                            eX_Renwus.article += "*" + aa.Gosum+ aa.GoName;
                        }
                       
                    }
                    if (i.Key == "sum")
                    {
                        eX_Renwus.Shsum = eX_Renwus.Shsum + Convert.ToInt32(i.Value.Trim());
                    }
                    if (i.Key == "specification")
                    {
                        aa.GoSpecification = i.Value.Trim();
                        if (eX_Renwus.article.Length < 50)
                        {
                            eX_Renwus.article += aa.GoSpecification;
                        }
                       
                    }
                    if (i.Key== "Cause")
                    {
                        eX_Renwus.Cause = i.Value.Trim();
                    }
                    
                }
                list1.Add(aa);
                
            }
            
            if (eX_Renwus.article.Length>30)
            {
                eX_Renwus.article += "......";
            }
           Random rad = new Random();//实例化随机bai数产生器rad；
            eX_Renwus.ShCoding =  "EW"+rad.Next(1000, 10000).ToString();//用rad生成大于等于1000，小于等于9999的随机数；
            eX_Renwus.Goodsidd = 1;
            
            eX_Renwus.State = 1;
            //时间
            eX_Renwus.Createtime = Convert.ToDateTime(DateTime.Now.ToLongDateString());
            List<EX_Renwu> ts =   _wMS.EX_Renwus(eX_Renwus).ToList();
            if (ts==null)
            {
                return Ok(0);
            }
            int yingxsum = _wMS.Ex_AddChukuwupin(list1, ts[0].ShipmentId.ToString());
            return Ok(yingxsum);

        }
       //所有出库任务
        [Route("/api/Rshow")]
        [HttpGet]
        public IActionResult Rshow(int pageIndex = 1, int pageSize = 3,string aaa=null, string times=null)
        {
            var PurchaseFromDto = _wMS.EX_Renwus();
            var aa = _mapper.Map<IEnumerable<EX_RenwusDto>>(PurchaseFromDto);
            if (!string.IsNullOrWhiteSpace(aaa))
            {
                aaa = aaa.Trim();
                aa = aa.Where(st => st.ShCoding == (aaa));
            }
            

            if (!string.IsNullOrWhiteSpace(times) || times == "null")
            {

                var sz = times.Split(",");
                string ba = sz[0].Replace(" GMT 0800 (中国标准时间)", "");
                string begin = Convert.ToDateTime(ba).ToString("yyyy-MM-dd");
                string oa = sz[1].Replace(" GMT 0800 (中国标准时间)", "");
                string over = Convert.ToDateTime(oa).ToString("yyyy-MM-dd");
                aa = aa.Where(t => t.Createtime > Convert.ToDateTime(begin) && t.Createtime < Convert.ToDateTime(over)).ToList();

            }
            int count = aa.Count();
            int page;
            if (count % pageSize == 0)
            {
                page = count / pageSize;
            }
            else
            {
                page = count / pageSize + 1;
            }
            EX_RenwusHrlper pd = new EX_RenwusHrlper();
            pd.pageSize = pageSize;
            pd.pageIndex = pageIndex;
            pd.totalCount = count;
            pd.EX_Renwus_list = aa.OrderBy(x => x.ShipmentId).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
            return Ok(pd);
        }
        //显示所有库存商品，方便用户选择
        [Route("/api/GoodsXuan")]
        [HttpGet]
        public IActionResult GoodsXuanze()
        {
            var PurchaseFromDto = _wMS.Ex_GoodsTWOs();
            var aa = _mapper.Map<IEnumerable<Ex_GoodsTWODto>>(PurchaseFromDto);

            return Ok(aa);
        }
        //显示出库任务所对应的商品明细
        //[Route("/api/Ex_GoodsShow")]
        //public IEnumerable<EX_GoodsOutbound> EX_GoodsOutboundsShow(string ids)
        //{
        //    var aa = _wMS.EX_GoodsOutboundsShow();
        //    if (!string.IsNullOrEmpty(ids))
        //    {
        //        aa = aa.Where(p => p.RenIdd == Convert.ToInt32(ids));
        //    }
        //    return aa;
        //}
        //日报表显示
        //[Route("/api/Daily")]
        //[HttpGet]
        //public IActionResult DailyStatements()
        //{
        //    return Ok(_wMS.DailyStatements());
        //}
        ////日报表数据
        //[Route("/api/Daily2")]
        //[HttpGet]
        //public IActionResult EX_Renwus(string time)
        //{
        //    return Ok(_wMS.EX_Renwus(time));
        //}
    }
}
