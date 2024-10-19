using Business.Interfaces.Repositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class SaleRepository : GenericRepository<Sale>, ISaleRepository
    {
        public SaleRepository()
        {
        }

        public async Task<IEnumerable<Sale>> GetSalesByUserIdAsync(int userId)
        {
            return await _context.Sales
            .Where(v => v.UserId == userId)
            .ToListAsync();
        }
    }
}
