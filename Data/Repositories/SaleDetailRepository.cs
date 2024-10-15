using Business.Interfaces.Repositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class SaleDetailRepository : GenericRepository<SaleDetail>, ISaleDetailRepository
    {
        public SaleDetailRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<SaleDetail>> GetDetailBySaleIdAsync(int saleId)
        {
            return await _context.SaleDetails
            .Where(dv => dv.SaleId == saleId)
            .ToListAsync();
        }
    }
}
