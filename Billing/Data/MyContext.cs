using Billing.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Billing.Data
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options)
            : base(options)
        {
        }

        /// <summary>
        /// Currency bills
        /// </summary>
        public DbSet<CurrencyBill> CurrencyBills { get; set; }
        
        /// <summary>
        /// Transactions
        /// </summary>
        public DbSet<Transaction> Transactions { get; set; }
    }
}