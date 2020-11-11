using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WMS.Models
{
    public class AOGQualityTest
    {
        [Key]
        public int AOGTestId { get; set; }
        public int AOGRegister { get; set; }
        public int AOGTestOknum { get; set; }
        public int AOGTestNonum { get; set; }
        public string AOGTestName { get; set; }
    }
}
