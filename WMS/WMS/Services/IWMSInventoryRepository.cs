using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WMS.Dtos;
using WMS.List;
using WMS.Models;

namespace WMS.Services
{
    public interface IWMSInventoryRepository
    {
        IEnumerable<Inventory_List> GetInventory();
        IEnumerable<EX_Warehouse> GetEX_Warehouse();
        void AddWareHouse(EX_Warehouse warehouse);
        IEnumerable<EX_ProductCategory> EX_ProductCategory();
        bool Save();
        IEnumerable<ReservoirArea_list> GetReservoirArea();
        void AddReservoirArea(EX_ReservoirArea reservoirArea);
        IEnumerable<EX_ReservoirArea> GetEX_ReservoirArea();
        void UptEX_ReservoirArea(ReservoirArea_list id);
        void DelEX_ReservoirArea(string id);
        IEnumerable<WRZ_list> GetGoodsAllocation();
        void AddGoodsAllocation(EX_Zhy zhy);
        void UptEX_Zhy(WRZ_list id);
        void DelEX_Zhy(string id);
        IEnumerable<WareHouseKeeperlist> WareHouseKeeperlist();
        void UptWareHouseKeeper(WareHouseKeeperlist id);
        IEnumerable<WareHouserKeeper> GetWareHouseKeeper();
        void AddKeeper(WareHouserKeeper k);
        void UptKeeper(KeeperDto id);
        public void StartUsing(int id);
        public void StopUsing(int id);
    }
}
