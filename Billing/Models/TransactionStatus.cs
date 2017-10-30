using System.ComponentModel.DataAnnotations;

namespace Billing.Models
{
    public enum TransactionStatus
    {
        [Display(Name = "Зачислено")]
        Appended,

        [Display(Name = "Списано")]
        Decommissioned,

        [Display(Name = "На зачислении")]
        Appending,

        [Display(Name = "В списании")]
        Decommissioning,

        [Display(Name = "На подтверждении")]
        Confirmating
    }
}