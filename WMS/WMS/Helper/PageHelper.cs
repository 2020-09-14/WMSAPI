using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WMS.List;
using WMS.Dtos;

using WMS.Models;



namespace WMS.Helper
{
    public class PageHelper
    {

        public List<CheckDto> CheckDtos { get; set; }

  
        public List<PurchaseShowDto> Purchase_list { get; set; }

        public int totalCount { get; set; }
        public int pageIndex { get; set; }
        public int pageSize { get; set; }
    }
}
