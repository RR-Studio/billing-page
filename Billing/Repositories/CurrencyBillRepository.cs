using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Billing.Data;
using Billing.Models;
using Microsoft.EntityFrameworkCore;

namespace Billing.Repositories
{
    public class CurrencyBillRepository
    {
        private readonly MyContext _context;

        public CurrencyBillRepository(MyContext context)
        {
            _context = context;
        }

        public async Task<List<CurrencyBill>> GetAll()
        {
            return await _context.CurrencyBills.ToListAsync();
        }
    }
}
