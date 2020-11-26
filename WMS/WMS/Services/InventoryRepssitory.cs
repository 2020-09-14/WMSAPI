using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WMS.Database;
using WMS.Dtos;
using WMS.List;
using WMS.Models;

namespace WMS.Services
{
    public class InventoryRepssitory : IWMSInventoryRepository
    {
        private readonly AppDbContext _appDbContext;
        public InventoryRepssitory(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        /// <summary>
        /// 添加仓库
        /// </summary>
        /// <returns></returns>
        public void AddWareHouse(EX_Warehouse warehouse)
        {
            if (warehouse == null)
            {
                throw new ArgumentException(nameof(warehouse));
            }
            _appDbContext.EX_Warehouse.Add(warehouse);
            _appDbContext.SaveChanges();
        }
        /// <summary>
        /// 保存 是否存储数据
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            return _appDbContext.SaveChanges() >= 0;
        }
        /// <summary>
        /// 显示品类下拉
        /// </summary>
        /// <returns></returns>
        public IEnumerable<EX_ProductCategory> EX_ProductCategory()
        {
            return _appDbContext.EX_ProductCategory.ToList();
        }

        /// <summary>
        /// 显示仓库下拉
        /// </summary>
        /// <returns></returns>
        public IEnumerable<EX_Warehouse> GetEX_Warehouse()
        {
            return _appDbContext.EX_Warehouse.ToList();
        }

        /// <summary>
        /// 显示总库存
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Inventory_List> GetInventory()
        {
            var aa = from p in _appDbContext.Set<ProWareHouse>()
                     join pc in _appDbContext.Set<EX_ProductCategory>()
                         on p.ProductCategoryId equals pc.ProductCategoryId
                     join w in _appDbContext.Set<EX_Warehouse>()
                         on p.WarehouseId equals w.WarehouseId
                     join g in _appDbContext.Set<Ex_GoodsTWO>()
                         on p.Ex_GoodsTWOId equals g.Ex_GoodsTWOId

                     select new { pc.ProductCategoryId, pc.Pidd, pc.ProductName, w.WarehouseId, w.Wname, w.Address, g.Ex_GoodsTWOId, g.GWname, g.Specification, g.OneIdd, g.Coding, g.TWOsum, g.EX_ZhyId };
            string str = JsonConvert.SerializeObject(aa);
            IEnumerable<Inventory_List> bb = JsonConvert.DeserializeObject<IEnumerable<Inventory_List>>(str);
            return bb;
        }
        /// <summary>
        /// 显示仓库库区
        /// </summary>
        /// <returns></returns>
        public IEnumerable<ReservoirArea_list> GetReservoirArea()
        {
            var a = from w in _appDbContext.Set<EX_Warehouse>()
                    join r in _appDbContext.Set<EX_ReservoirArea>()
                    on w.WarehouseId equals r.WIdd
                    select new
                    {
                        w.WarehouseId,
                        w.Wname,
                        r.Rname,
                        r.TemperatureZone
                    };
            string str = JsonConvert.SerializeObject(a);
            IEnumerable<ReservoirArea_list> b = JsonConvert.DeserializeObject<IEnumerable<ReservoirArea_list>>(str);
            return b;
        }
        /// <summary>
        /// 添加库区
        /// </summary>
        /// <param name="reservoirArea"></param>
        public void AddReservoirArea(EX_ReservoirArea reservoirArea)
        {
            if (reservoirArea == null)
            {
                throw new ArgumentException(nameof(reservoirArea));
            }
            _appDbContext.EX_ReservoirArea.Add(reservoirArea);
            _appDbContext.SaveChanges();
        }
        /// <summary>
        /// 显示库区
        /// </summary>
        /// <returns></returns>
        public IEnumerable<EX_ReservoirArea> GetEX_ReservoirArea()
        {
            return _appDbContext.EX_ReservoirArea.ToList();
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="id"></param>
        public void UptEX_ReservoirArea(ReservoirArea_list id)
        {
            var aa = _appDbContext.ReservoirArea_list.Where(r => r.WarehouseId.Equals(id.WarehouseId)).FirstOrDefault();
            aa.Rname = id.Rname;
            aa.Remark = id.Remark;
            aa.TemperatureZone = id.TemperatureZone;
            aa.WIdd = id.WIdd;
            _appDbContext.SaveChanges();
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        public void DelEX_ReservoirArea(string id)
        {
            int a = Convert.ToInt32(id);
            var aa = _appDbContext.EX_ReservoirArea.Where(s => s.WIdd == a).FirstOrDefault();
            _appDbContext.EX_ReservoirArea.Remove(aa);
            _appDbContext.SaveChanges();

        }
        /// <summary>
        /// 显示仓库库区货位
        /// </summary>
        /// <returns></returns>
        public IEnumerable<WRZ_list> GetGoodsAllocation()
        {
            var a = from w in _appDbContext.Set<EX_Warehouse>()
                    join r in _appDbContext.Set<EX_ReservoirArea>()
                    on w.WarehouseId equals r.WIdd
                    join z in _appDbContext.Set<EX_Zhy>()
                    on r.ReservoirAreaId equals z.Ridd
                    select new
                    {
                        w.WarehouseId,
                        w.Wname,
                        r.Rname,
                        z.Zname
                    };
            string str = JsonConvert.SerializeObject(a);
            IEnumerable<WRZ_list> b = JsonConvert.DeserializeObject<IEnumerable<WRZ_list>>(str);
            return b;
        }
        /// <summary>
        /// 添加货位
        /// </summary>
        /// <param name="zhy"></param>
        public void AddGoodsAllocation(EX_Zhy zhy)
        {
            if (zhy == null)
            {
                throw new ArgumentException(nameof(zhy));
            }
            _appDbContext.EX_Zhy.Add(zhy);
            _appDbContext.SaveChanges();
        }
        /// <summary>
        /// 修改库区
        /// </summary>
        /// <param name="id"></param>
        public void UptEX_Zhy(WRZ_list id)
        {
            var aa = _appDbContext.WRZ_list.Where(r => r.WarehouseId.Equals(id.WarehouseId)).FirstOrDefault();
            aa.Rname = id.Rname;
            aa.Remark = id.Remark;
            aa.InventorySettings = id.InventorySettings;
            aa.Ridd = id.Ridd;
            _appDbContext.SaveChanges();
        }
        /// <summary>
        /// 删除货位
        /// </summary>
        /// <param name="id"></param>
        public void DelEX_Zhy(string id)
        {
            int a = Convert.ToInt32(id);
            var aa = _appDbContext.EX_Zhy.Where(s => s.ZhyId == a).FirstOrDefault();
            _appDbContext.EX_Zhy.Remove(aa);
            _appDbContext.SaveChanges();
        }
        /// <summary>
        /// 仓库管理权限 查询显示
        /// </summary>
        /// <returns></returns>
        public IEnumerable<WareHouseKeeperlist> WareHouseKeeperlist()
        {
            var a = from w in _appDbContext.Set<EX_Warehouse>()
                    join r in _appDbContext.Set<EX_ReservoirArea>()
                    on w.WarehouseId equals r.WIdd
                    join k in _appDbContext.Set<WareHouserKeeper>()
                    on w.WarehouseId equals k.WId
                    select new
                    {
                        w.WarehouseId,
                        w.Wname,
                        r.Rname,
                        k.KeeperName,
                        k.KeeperPhone
                    };
            string str = JsonConvert.SerializeObject(a);
            IEnumerable<WareHouseKeeperlist> b = JsonConvert.DeserializeObject<IEnumerable<WareHouseKeeperlist>>(str);
            return b;
        }
        /// <summary>
        /// 修改权限
        /// </summary>
        /// <param name="id"></param>
        public void UptWareHouseKeeper(WareHouseKeeperlist id)
        {
            var aa = _appDbContext.WareHouseKeeperlist.Where(r => r.WarehouseId.Equals(id.WarehouseId)).FirstOrDefault();
            aa.WId = id.WId;
            _appDbContext.SaveChanges();
        }
        /// <summary>
        /// 显示库管理员
        /// </summary>
        /// <returns></returns>
        public IEnumerable<WareHouserKeeper> GetWareHouseKeeper()
        {
            return _appDbContext.WareHouserKeeper.ToList();
        }
        /// <summary>
        /// 添加库管员
        /// </summary>
        /// <param name="zhy"></param>
        public void AddKeeper(WareHouserKeeper k)
        {
            if (k == null)
            {
                throw new ArgumentException(nameof(k));
            }
            _appDbContext.WareHouserKeeper.Add(k);
            _appDbContext.SaveChanges();
        }
        /// <summary>
        /// 修改库管理员
        /// </summary>
        /// <param name="id"></param>
        public void UptKeeper(KeeperDto id)
        {
            var aa = _appDbContext.WareHouserKeeper.Where(r => r.WareHouserKeeperId.Equals(id.WareHouserKeeperId)).FirstOrDefault();
            aa.KeeperName = id.KeeperName;
            aa.KeeperPhone = id.KeeperPhone;
            _appDbContext.SaveChanges();
        }
        /// <summary>
        /// 更改状态
        /// </summary>
        /// <param name="id"></param>
        public void StartUsing(int id)
        {
            var aa = _appDbContext.WareHouserKeeper.Where(r => r.WareHouserKeeperId.Equals(id)).FirstOrDefault();
            aa.State = 1;
            _appDbContext.SaveChanges();
        }
        /// <summary>
        /// 更改状态
        /// </summary>
        /// <param name="id"></param>
        public void StopUsing(int id)
        {
            var aa = _appDbContext.WareHouserKeeper.Where(r => r.WareHouserKeeperId.Equals(id)).FirstOrDefault();
            aa.State = 0;
            _appDbContext.SaveChanges();
        }
    }
}
