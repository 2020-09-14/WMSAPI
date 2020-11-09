using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WMS.Database;
using WMS.Models;

namespace WMS.Services
{
    public class StudentsRepository : IWMSRepository
    {
        private readonly AppDbContext _appDbContext;
        public StudentsRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<IEnumerable<Students>> GetStudents()
        {
            return await _appDbContext.Students.ToListAsync();
        }
    }
}
