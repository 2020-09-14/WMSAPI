using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WMS.Dtos;
namespace WMS.Helper
{
    public class EX_RenwusHrlper
    {
        public List<EX_RenwusDto> EX_Renwus_list { get; set; }
        public int totalCount { get; set; }
        public int pageIndex { get; set; }
        public int pageSize { get; set; }
    }
}
