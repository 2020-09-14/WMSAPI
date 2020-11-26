using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WMS.Dtos;
using WMS.List;
using WMS.Models;

namespace WMS.Services
{
   public interface IWMSCheckRepository
    {

        IEnumerable<check_list> GetCheck();
        int  AddChecka(Check check);
        bool Save();
        IEnumerable<Check> GetCheckNo();
        IEnumerable<Check> GetCheckYes();
        //实盘的显示
        IEnumerable<check_list> CheckShi();
        //审核调整
        IEnumerable<Check> GetCheckShen();

    }
}
