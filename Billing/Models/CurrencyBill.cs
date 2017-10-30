namespace Billing.Models
{
    public class CurrencyBill
    {
        /// <summary>
        /// Bill id
        /// </summary>
        public int Id { get; set; }
        
        /// <summary>
        /// Currancy sort name
        /// </summary>
        public string Currency { get; set; }

        /// <summary>
        /// Total amount
        /// </summary>
        public decimal Amount { get; set; }
        
        /// <summary>
        /// Available amount
        /// </summary>
        public decimal Available { get; set; }

        /// <summary>
        /// Amount of currency in orders
        /// </summary>
        public decimal OrdersAmount { get; set; }

        /// <summary>
        /// Amount of appending currency
        /// </summary>
        public decimal AppendingAmount { get; set; }

        /// <summary>
        /// Amount of decommissioning currency
        /// </summary>
        public decimal DecommissioningAmount { get; set; }
        
        
    }
}