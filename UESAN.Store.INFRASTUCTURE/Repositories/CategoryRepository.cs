using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UESAN.Store.CORE.Interfaces;
using UESAN.Store.INFRASTUCTURE.Data;
using UESAN.STORE.CORE.Entities;

namespace UESAN.Store.INFRASTUCTURE.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly StoreDbContext _dbcontext;

        public CategoryRepository(StoreDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public async Task<IEnumerable<Category>> GetALL()
        {
            var result = await _dbcontext.Category.ToListAsync();
            return result;
        }
    }
}
