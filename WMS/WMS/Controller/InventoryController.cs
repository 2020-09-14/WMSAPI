using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WMS.Dtos;
using WMS.Helper;
using WMS.List;
using WMS.Models;
using WMS.Services;

namespace WMS.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        private IWMSInventoryRepository _wMs;
        private IMapper _mapper;
        public InventoryController(IWMSInventoryRepository wMs, IMapper mapper)
        {
            _wMs = wMs;
            _mapper = mapper;
        }
        /// <summary>
        /// 分页显示总库存
        /// </summary>
        /// <returns></returns>
        [Route("/api/GetInventory")]
        [HttpGet]
        public PHelper GetInventory(string whid, string pcid, string coding, string gwname, int pageIndex = 1, int pageSize = 3)
        {
            var InventoryFormDto = _wMs.GetInventory();
            var InventoryDto = _mapper.Map<IEnumerable<InventoryDto>>(InventoryFormDto);

            if (!string.IsNullOrWhiteSpace(whid))//仓库名称
            {
                var w = Convert.ToInt32(whid);
                InventoryDto = InventoryDto.Where(it => it.WarehouseId.Equals(w));
            }
            if (!string.IsNullOrWhiteSpace(pcid))//商品品类
            {
                var p = Convert.ToInt32(pcid);
                InventoryDto = InventoryDto.Where(it => it.ProductCategoryId.Equals(p));
            }
            if (!string.IsNullOrWhiteSpace(coding))//商品编码
            {
                coding = coding.Trim();
                InventoryDto = InventoryDto.Where(it => it.Coding.Contains(coding));
            }
            if (!string.IsNullOrWhiteSpace(gwname))//商品名称
            {
                gwname = gwname.Trim();
                InventoryDto = InventoryDto.Where(it => it.GWname.Contains(gwname));
            }


            int count = InventoryDto.Count();//数据总条数
            int page;//页数
            if (count % pageSize == 0)
            {
                page = count / pageSize;
            }
            else
            {
                page = count / pageSize + 1;
            }
            PHelper pd = new PHelper();
            pd.pageSize = pageSize;
            pd.pageIndex = pageIndex;
            pd.totalCount = count;
            pd.Inventory_List = InventoryDto.OrderBy(x => x.WarehouseId).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
            return pd;

        }
        /// <summary>
        /// 显示仓库下拉
        /// </summary>
        /// <returns></returns>
        [Route("/api/GetEX_Warehouse")]
        [HttpGet]
        public IActionResult GetEX_Warehouse()
        {
            var WareHouseformDto = _wMs.GetEX_Warehouse();
            if (WareHouseformDto == null || WareHouseformDto.Count() <= 0)
            {
                return NotFound("没有数据！！！");
            }
            var WareHouse = _mapper.Map<IEnumerable<EX_WarehouseDto>>(WareHouseformDto);
            return Ok(WareHouse);
        }
        /// <summary>
        /// 显示品类下拉
        /// </summary>
        /// <returns></returns>
        [Route("/api/GetEX_ProductCategory")]
        [HttpGet]
        public IActionResult GetEX_ProductCategory()
        {
            var GetEX_ProductCategoryformDto = _wMs.EX_ProductCategory();
            if (GetEX_ProductCategoryformDto == null || GetEX_ProductCategoryformDto.Count() <= 0)
            {
                return NotFound("没有数据！！！");
            }
            var ProductCategory = _mapper.Map<IEnumerable<EX_ProductCategory>>(GetEX_ProductCategoryformDto);
            return Ok(ProductCategory);
        }
        /// <summary>
        /// 添加仓库
        /// </summary>
        /// <param name="warehouseDto"></param>
        /// <returns></returns>
        [Route("/api/AddWareHouse")]
        [HttpPost]
        public IActionResult AddWareHouse([FromBody] CreateWareHouseDto warehouseDto)
        {
            var warehouseModel = _mapper.Map<EX_Warehouse>(warehouseDto);
            _wMs.AddWareHouse(warehouseModel);
            var a = _wMs.Save();
            return Ok(a);
        }
        /// <summary>
        /// 查询显示仓库库区
        /// </summary>
        /// <param name="whid"></param>
        /// <param name="rname"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        [Route("/api/GetReservoirArea")]
        [HttpGet]
        public PHelper GetReservoirArea(string whid, string rname, int pageIndex = 1, int pageSize = 3)
        {
            var ReservoirFormDto = _wMs.GetReservoirArea();
            var ReservoirAreaDto = _mapper.Map<IEnumerable<ReservoirAreaDto>>(ReservoirFormDto);

            if (!string.IsNullOrWhiteSpace(whid))//仓库名称
            {
                var w = Convert.ToInt32(whid);
                ReservoirAreaDto = ReservoirAreaDto.Where(it => it.WarehouseId.Equals(w));
            }
            if (!string.IsNullOrWhiteSpace(rname))//库区名称
            {
                rname = rname.Trim();
                ReservoirAreaDto = ReservoirAreaDto.Where(it => it.Rname.Contains(rname));
            }


            int count = ReservoirAreaDto.Count();//数据总条数
            int page;//页数
            if (count % pageSize == 0)
            {
                page = count / pageSize;
            }
            else
            {
                page = count / pageSize + 1;
            }
            PHelper pd = new PHelper();
            pd.pageSize = pageSize;
            pd.pageIndex = pageIndex;
            pd.totalCount = count;
            pd.ReservoirArea_list = ReservoirAreaDto.OrderBy(x => x.WarehouseId).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
            return pd;

        }
        /// <summary>
        /// 添加库区
        /// </summary>
        /// <param name="warehouseDto"></param>
        /// <returns></returns>
        [Route("/api/AddReservoirArea")]
        [HttpPost]
        public IActionResult AddReservoirArea([FromBody] CreateReservoirAreaDto reservoirAreaDto)
        {
            var reservoirAreaModel = _mapper.Map<EX_ReservoirArea>(reservoirAreaDto);
            _wMs.AddReservoirArea(reservoirAreaModel);
            var a = _wMs.Save();
            return Ok(a);
        }
        /// <summary>
        /// 显示库区
        /// </summary>
        /// <returns></returns>
        [Route("/api/GetEX_ReservoirArea")]
        [HttpGet]
        public IActionResult GetEX_ReservoirArea()
        {
            var ReservoirAreaFormDto = _wMs.GetEX_ReservoirArea();
            if (ReservoirAreaFormDto == null || ReservoirAreaFormDto.Count() <= 0)
            {
                return NotFound("没有数据！！！");
            }
            var ReservoirArea = _mapper.Map<IEnumerable<EX_ReservoirArea>>(ReservoirAreaFormDto);
            return Ok(ReservoirArea);
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="id"></param>
        [Route("/api/UptEX_ReservoirArea")]
        [HttpGet]
        public IActionResult UptEX_ReservoirArea(ReservoirArea_list id)
        {
            _wMs.UptEX_ReservoirArea(id);
            var a = _wMs.Save();
            return Ok(a);
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        [Route("/api/DelEX_ReservoirArea")]
        [HttpGet]
        public IActionResult DelEX_ReservoirArea(string id)
        {
            _wMs.DelEX_ReservoirArea(id);
            var a = _wMs.Save();
            return Ok(a);
        }
        /// <summary>
        /// 查询显示仓库库区
        /// </summary>
        /// <param name="whid"></param>
        /// <param name="rname"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        [Route("/api/GetGoodsAllocation")]
        [HttpGet]
        public PHelper GetGoodsAllocation(string whid, string rname, int pageIndex = 1, int pageSize = 3)
        {
            var GoodsAllocationFormDto = _wMs.GetGoodsAllocation();
            var GoodsAllocationDto = _mapper.Map<IEnumerable<GoodsAllocationDto>>(GoodsAllocationFormDto);

            if (!string.IsNullOrWhiteSpace(whid))//仓库名称
            {
                var w = Convert.ToInt32(whid);
                GoodsAllocationDto = GoodsAllocationDto.Where(it => it.WarehouseId.Equals(w));
            }
            if (!string.IsNullOrWhiteSpace(rname))//库区名称
            {
                rname = rname.Trim();
                GoodsAllocationDto = GoodsAllocationDto.Where(it => it.Rname.Contains(rname));
            }


            int count = GoodsAllocationDto.Count();//数据总条数
            int page;//页数
            if (count % pageSize == 0)
            {
                page = count / pageSize;
            }
            else
            {
                page = count / pageSize + 1;
            }
            PHelper pd = new PHelper();
            pd.pageSize = pageSize;
            pd.pageIndex = pageIndex;
            pd.totalCount = count;
            pd.WRZ_list = GoodsAllocationDto.OrderBy(x => x.WarehouseId).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
            return pd;
        }
        /// <summary>
        /// 添加库位
        /// </summary>
        /// <param name="warehouseDto"></param>
        /// <returns></returns>
        [Route("/api/AddGoodsAllocation")]
        [HttpPost]
        public IActionResult AddGoodsAllocation([FromBody] CreateGoodsAllocationDto goodsAllocationDto)
        {
            var goodsAllocationModel = _mapper.Map<EX_Zhy>(goodsAllocationDto);
            _wMs.AddGoodsAllocation(goodsAllocationModel);
            var a = _wMs.Save();
            return Ok(a);
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="id"></param>
        [Route("/api/UptEX_Zhy")]
        [HttpGet]
        public IActionResult UptEX_Zhy(WRZ_list id)
        {
            _wMs.UptEX_Zhy(id);
            var a = _wMs.Save();
            return Ok(a);
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        [Route("/api/DelEX_Zhy")]
        [HttpGet]
        public IActionResult DelEX_Zhy(string id)
        {
            _wMs.DelEX_Zhy(id);
            var a = _wMs.Save();
            return Ok(a);
        }
        /// <summary>
        /// 仓库管理权限 查询显示
        /// </summary>
        /// <param name="whid"></param>
        /// <param name="keepername"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        [Route("/api/WareHouseKeeperlist")]
        [HttpGet]
        public PHelper WareHouseKeeperlist(string whid, string keepername, int pageIndex = 1, int pageSize = 3)
        {
            var WareHouseKeeperFormDto = _wMs.WareHouseKeeperlist();
            var WareHouseKeeperDto = _mapper.Map<IEnumerable<WareHouseKeeperDto>>(WareHouseKeeperFormDto);

            if (!string.IsNullOrWhiteSpace(whid))
            {
                var w = Convert.ToInt32(whid);
                WareHouseKeeperDto = WareHouseKeeperDto.Where(it => it.WarehouseId.Equals(w));
            }
            if (!string.IsNullOrWhiteSpace(keepername))
            {
                keepername = keepername.Trim();
                WareHouseKeeperDto = WareHouseKeeperDto.Where(it => it.Rname.Contains(keepername));
            }


            int count = WareHouseKeeperDto.Count();//数据总条数
            int page;//页数
            if (count % pageSize == 0)
            {
                page = count / pageSize;
            }
            else
            {
                page = count / pageSize + 1;
            }
            PHelper pd = new PHelper();
            pd.pageSize = pageSize;
            pd.pageIndex = pageIndex;
            pd.totalCount = count;
            pd.WareHouseKeeperDto = WareHouseKeeperDto.OrderBy(x => x.WarehouseId).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
            return pd;
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="id"></param>
        [Route("/api/UptWareHouseKeeper")]
        [HttpGet]
        public IActionResult UptWareHouseKeeper(WareHouseKeeperlist id)
        {
            _wMs.UptWareHouseKeeper(id);
            var a = _wMs.Save();
            return Ok(a);
        }
        /// <summary>
        /// 库管员显示
        /// </summary>
        /// <param name="whid"></param>
        /// <param name="keepername"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        [Route("/api/GetWareHouseKeeper")]
        [HttpGet]
        public PHelper GetWareHouseKeeper(string keepername, string keeperPhone, int pageIndex = 1, int pageSize = 3)
        {
            var KeeperFormDto = _wMs.GetWareHouseKeeper();
            var KeeperDto = _mapper.Map<IEnumerable<KeeperDto>>(KeeperFormDto);
            if (!string.IsNullOrWhiteSpace(keepername))
            {
                keepername = keepername.Trim();
                KeeperDto = KeeperDto.Where(it => it.KeeperName.Contains(keepername));
            }
            if (!string.IsNullOrWhiteSpace(keeperPhone))
            {
                keeperPhone = keeperPhone.Trim();
                KeeperDto = KeeperDto.Where(it => it.KeeperPhone.Equals(keeperPhone));
            }
            


            int count = KeeperDto.Count();//数据总条数
            int page;//页数
            if (count % pageSize == 0)
            {
                page = count / pageSize;
            }
            else
            {
                page = count / pageSize + 1;
            }
            PHelper pd = new PHelper();
            pd.pageSize = pageSize;
            pd.pageIndex = pageIndex;
            pd.totalCount = count;
            pd.KeeperDto = KeeperDto.OrderBy(x => x.WareHouserKeeperId).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
            return pd;
        }
        /// <summary>
        /// 添加库管理员
        /// </summary>
        /// <param name="keeper"></param>
        /// <returns></returns>
        [Route("/api/AddKeeper")]
        [HttpPost]
        public IActionResult AddKeeper([FromBody] CreateWareHouseKeeperDto keeper)
        {
            var keeperModel = _mapper.Map<WareHouserKeeper>(keeper);
            _wMs.AddKeeper(keeperModel);
            var a = _wMs.Save();
            return Ok(a);
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="id"></param>
        [Route("/api/UptKeeper")]
        [HttpGet]
        public IActionResult UptKeeper(KeeperDto id)
        {
            _wMs.UptKeeper(id);
            var a = _wMs.Save();
            return Ok(a);
        }
        /// <summary>
        /// 更改状态
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        [Route("/api/StartUsing")]
        [HttpGet]
        public IActionResult StartUsing(int id)
        {
            _wMs.StartUsing(id);
            var a = _wMs.Save();
            return Ok(a);
        }
        /// <summary>
        /// 更改状态
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        [Route("/api/StopUsing")]
        [HttpGet]
        public IActionResult StopUsing(int id)
        {
            _wMs.StopUsing(id);
            var a = _wMs.Save();
            return Ok(a);
        }
    }
}
