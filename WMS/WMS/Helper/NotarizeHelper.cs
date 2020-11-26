using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WMS.Dtos;

namespace WMS.Helper
{
    public class NotarizeHelper
    {
        public List<NotarizeShowDto> Notarize_list { get; set; }

        public int totalCount { get; set; }
        public int pageIndex { get; set; }
        public int pageSize { get; set; }
    }
}
