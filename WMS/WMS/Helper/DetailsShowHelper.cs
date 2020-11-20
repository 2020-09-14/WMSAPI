using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WMS.List;

namespace WMS.Helper
{
    public class DetailsShowHelper
    {
        public List<Details_List> Details_List { get; set; }

        public int totalCount { get; set; }
        public int pageIndex { get; set; }
        public int pageSize { get; set; }
    }
}
