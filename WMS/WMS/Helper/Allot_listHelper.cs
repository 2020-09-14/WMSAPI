using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WMS.Dtos;

namespace WMS.Helper
{
    public class Allot_listHelper
    {
        public List<AllotShowDto> Allot_list { get; set; }
       
        public int totalCount { get; set; }
        public int pageIndex { get; set; }
        public int pageSize { get; set; }
    }
}
