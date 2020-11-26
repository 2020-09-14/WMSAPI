using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WMS.Models;

namespace WMS.Services
{
   public interface IWMSRepository
    {
        //Task<IEnumerable<Students>> GetStudents();//显示数据接口
        Task<bool> SaveAsync();//保存
        void  AddWareHouse(EX_Warehouse w);//添加数据接口

    }
}
