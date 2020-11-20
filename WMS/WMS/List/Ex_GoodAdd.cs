using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WMS.List
{
    [NotMapped]
    public class Ex_GoodAdd
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string age { get; set; }
        public int sum { get; set; }
    }
}
