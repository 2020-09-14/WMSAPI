using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WMS.List
{
    [NotMapped]
    public class EX_studentList
    {





        public List<Ex_GoodAdd> list { get; set; }
    }
}
