using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WMS.List;
using WMS.Models;
using WMS.Dtos;
namespace WMS.Helper
{
    public class ItemdetailsShowHelper
    {
        public List<ItemdetailsShowDto> Itemdetails_list { get; set; }

        public int totalCount { get; set; }
        public int pageIndex { get; set; }
        public int pageSize { get; set; }
    }
}
