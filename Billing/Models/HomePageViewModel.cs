using System;
using System.Collections.Generic;

namespace Billing.Models
{
    public class HomePageViewModel
    {
        /// <summary>
        /// Transactions list
        /// </summary>
        /// <value>The transactions.</value>
        public List<Transaction> Transactions { get; set; }

        /// <summary>
        /// Currency bills list
        /// </summary>
        /// <value>The currency bills.</value>
        public List<CurrencyBill> CurrencyBills { get; set;}
    }
}
