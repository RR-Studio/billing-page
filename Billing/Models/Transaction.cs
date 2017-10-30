using System;

namespace Billing.Models
{
    public class Transaction
    {
        /// <summary>
        /// Bill item is
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Date time transaction created
        /// </summary>
        public DateTime DateTime { get; set; }
        
        /// <summary>
        /// Currency short name
        /// </summary>
        public string CurrencyName { get; set; }

        /// <summary>
        /// Amount
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// Transaction status
        /// </summary>
        public TransactionStatus TransactionStatus { get; set; }
        
        /// <summary>
        /// Confirmations count
        /// </summary>
        public int ConfirmationsCount { get; set; }
    }
}