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
        
        /// <summary>
        /// 保存
        /// </summary>
        /// <returns></returns>
        public async Task<bool> SaveAsync()
        {
            return (await _appDbContext.SaveChangesAsync() >= 0);
        }
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="w"></param>
        public void AddWareHouse(EX_Warehouse w)
        {
            if (w == null)
            {
                throw new ArgumentException(nameof(w));
            }
            _appDbContext.EX_Warehouse.Add(w);
            _appDbContext.SaveChanges();
        }
    }
}
