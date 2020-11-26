using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WMS.Dtos;
using WMS.Models;

namespace WMS.Helper
{
    public class BStorageHelper
    {
        public List<BStorageShowDto> bstorage_list { get; set; }

        public int totalCount { get; set; }
        public int pageIndex { get; set; }
        public int pageSize { get; set; }
    }
}
