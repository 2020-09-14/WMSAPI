using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WMS.Models
{
    public class GodownTodo
    {
        [Key]
        public int GodownTodoId { get; set; }
        public string GodownTodoNum { get; set; }
        public int GodownTodoPurchaseId { get; set; }
        public int GodownTodoState { get; set; }


    }
}
