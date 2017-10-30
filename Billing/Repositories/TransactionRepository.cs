using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Billing.Data;
using Billing.Models;
using Microsoft.EntityFrameworkCore;

namespace Billing.Repositories
{
    public class TransactionRepository
    {
        private readonly MyContext _context;

        public TransactionRepository(MyContext context)
        {
            _context = context;
        }

        public async Task<List<Transaction>> GetAll()
        {
            return await _context.Transactions.ToListAsync();
        }
    }
}
