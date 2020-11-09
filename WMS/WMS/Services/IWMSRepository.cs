using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WMS.Models;

namespace WMS.Services
{
   public interface IWMSRepository
    {
        Task<IEnumerable<Students>> GetStudents();
    }
}
