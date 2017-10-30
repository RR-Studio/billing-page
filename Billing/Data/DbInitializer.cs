using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Billing.Models;
using SQLitePCL;

namespace Billing.Data
{
    public class DbInitializer
    {

        public static async Task Initialize(MyContext context)
        {
            context.Database.EnsureCreated();
            await Seed(context);
           
        }

        public static async Task Seed(MyContext serviceProvider)
        {
            await SeedBills(serviceProvider);
            await SeedTransactions(serviceProvider);
        }

        private static async Task SeedBills(MyContext dbContext)
        {
            if (!dbContext.CurrencyBills.Any())
            {
                await dbContext.CurrencyBills.AddRangeAsync(new List<CurrencyBill>
                {
                    new CurrencyBill() {
                        Currency = "BTC",
                        Amount = 100000,
                        Available = 50000,
                        OrdersAmount = 30000,
                        AppendingAmount = 30000,
                        DecommissioningAmount = 25000
                    },
                    new CurrencyBill() {
                        Currency = "ETH",
                        Amount = 200000,
                        Available = 100000,
                        OrdersAmount = 60000,
                        AppendingAmount = 60000,
                        DecommissioningAmount = 60000
                    },
                    new CurrencyBill() {
                        Currency = "LTC",
                        Amount = 50000,
                        Available = 25000,
                        OrdersAmount = 16000,
                        AppendingAmount = 14000,
                        DecommissioningAmount = 12500
                    },
                    new CurrencyBill() {
                        Currency = "DSH",
                        Amount = 200000,
                        Available = 25000,
                        OrdersAmount = 60000,
                        AppendingAmount = 15000,
                        DecommissioningAmount = 25000
                    },
                    new CurrencyBill() {
                        Currency = "NMC",
                        Amount = 100000,
                        Available = 50000,
                        OrdersAmount = 30000,
                        AppendingAmount = 30000,
                        DecommissioningAmount = 25000
                    }
                });
            }

            await dbContext.SaveChangesAsync();
        }


        public static async Task SeedTransactions(MyContext dbContext)
        {
            if (!dbContext.Transactions.Any())
            {
                await dbContext.Transactions.AddRangeAsync(new List<Transaction>
                {
                    new Transaction(){
                        DateTime = DateTime.Now,
                        CurrencyName = "BTC",
                        Amount = 2.5m,
                        TransactionStatus = TransactionStatus.Appended,
                        ConfirmationsCount = 25
                    },
                new Transaction(){
                        DateTime = DateTime.Now,
                        CurrencyName = "ETH",
                        Amount = 3.5m,
                        TransactionStatus = TransactionStatus.Appended,
                        ConfirmationsCount = 250
                    },
                new Transaction(){
                        DateTime = DateTime.Now,
                        CurrencyName = "LTC",
                        Amount = 40,
                        TransactionStatus = TransactionStatus.Appended,
                        ConfirmationsCount = 2500
                    }
                });
            }

            await dbContext.SaveChangesAsync();
        }

    }
}