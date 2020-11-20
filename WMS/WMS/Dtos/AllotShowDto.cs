using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WMS.Dtos
{
    public class AllotShowDto
    {
        public int AId { get; set; }
        public string ARequisition { get; set; }
        public string ACallout { get; set; }
        public string AFold { get; set; }
        public string APerson { get; set; }
        public DateTime ADate { get; set; }
        public int AAuditstatus { get; set; }
        public int AAllocatingstate { get; set; }
        public int APackingquantity { get; set; }
        public int AWId { get; set; }
    }
}
